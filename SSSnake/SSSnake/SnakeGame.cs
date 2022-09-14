using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.TextureAtlases;
using MonoGame.Extended.ViewportAdapters;
using SSSnake.Contents;
using SSSnake.State;

namespace SSSnake;

public class SnakeGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public SnakeGame()
    {
        _graphics = new(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    public OrthographicCamera Camera;

    protected override void Initialize()
    {
        base.Initialize();
        var adapter = new BoxingViewportAdapter(Window, GraphicsDevice, GraphicsDevice.Viewport.Width,
            GraphicsDevice.Viewport.Height);
        Camera = new OrthographicCamera(adapter);
    }

    protected override void LoadContent()
    {
        var textures = Vars.AssetDir.GetFiles("*.png", SearchOption.AllDirectories);
        foreach (var textureFile in textures)
        {
            using var stream = textureFile.Open(FileMode.Open);
            var name = Path.GetFileNameWithoutExtension(textureFile.Name);
            var texture = Texture2D.FromStream(GraphicsDevice, stream);
            var region = new TextureRegion2D(name, texture, 0, 0, texture.Width, texture.Height);
            Resource.Textures[name] = region;
            if (name == Resource.ErrorName)
                Resource.Error = region;
        }

        ContentLoader.Load();
        foreach (var contents in GameContent.All)
        {
            foreach (var content in contents)
            {
                content.LoadResource();
            }
        }
    }

    private Vector2 GetMovementDirection()
    {
        var movementDirection = Vector2.Zero;
        var state = Keyboard.GetState();
        if (state.IsKeyDown(Keys.Down))
        {
            movementDirection += Vector2.UnitY;
        }

        if (state.IsKeyDown(Keys.Up))
        {
            movementDirection -= Vector2.UnitY;
        }

        if (state.IsKeyDown(Keys.Left))
        {
            movementDirection -= Vector2.UnitX;
        }

        if (state.IsKeyDown(Keys.Right))
        {
            movementDirection += Vector2.UnitX;
        }

        return movementDirection;
    }

    private float GetZoom()
    {
        var zoom = 0f;
        var state = Keyboard.GetState();
        if (state.IsKeyDown(Keys.Add))
        {
            zoom += 1f;
        }

        if (state.IsKeyDown(Keys.Subtract))
        {
            zoom -= 1f;
        }

        return zoom;
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        const float movementSpeed = 200;
        Camera.Move(GetMovementDirection() * movementSpeed * gameTime.GetElapsedSeconds());
        const float zoomSpeed = 0.01f;
        Camera.ZoomOut(GetZoom() * zoomSpeed);
        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        if (Vars.State == GameState.Load)
        {
            var world = new World();
            world.CreateTiles(50, 50);
            Vars.World = world;
            world.Fill((x, y) => new Tile
            {
                Block = Blocks.Error,
                X = x,
                Y = y
            });
            //world.Tiles[0, 0].Block = Blocks.Test;
            // world.Tiles[0, 1].Block = Blocks.Error;
            Vars.State = GameState.Play;
        }
    }

    protected override void Draw(GameTime gameTime)
    {
        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        _graphics.GraphicsDevice.Clear(Color.Black);
        var matrix = Camera.GetViewMatrix();
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        Drawf.PushBatch(_spriteBatch);
        _spriteBatch.Begin(transformMatrix: matrix);
        if (Vars.State is GameState.Play or GameState.Pause)
        {
            Vars.World.Draw();
        }

        Drawf.PopBatch();
        _spriteBatch.End();
    }
}