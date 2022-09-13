using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        var textures = Vars.AssetDir.GetFiles("*.png",SearchOption.AllDirectories);
        foreach (var texture in textures)
        {
            using var stream = texture.Open(FileMode.Open);
            var name = Path.GetFileNameWithoutExtension(texture.Name); 
            var tex = new TextureRegion(Texture2D.FromStream(GraphicsDevice, stream));
            Resource.Textures[name] = tex;
            if (name == Resource.ErrorName)
                Resource.Error = tex;
           
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

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        if (Vars.State == GameState.Load)
        {
            var world = new World
            {
                Tiles = new Tile[50, 50]
            };
            Vars.World = world;
            Vars.State = GameState.Play;
        }
    }

    protected override void Draw(GameTime gameTime)
    {
        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        _graphics.GraphicsDevice.Clear(Color.Black);
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _spriteBatch.Begin();
        if (Vars.State is GameState.Play or GameState.Pause)
        {
            Vars.World.Draw();
        }

        _spriteBatch.End();
    }
}