using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SSSnake;

public class SnakeGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public SnakeGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }
    Texture2D whiteHeadTexture;
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        using var fileStream = new FileStream("Assets/white-head.png", FileMode.Open);
        whiteHeadTexture = Texture2D.FromStream(_graphics.GraphicsDevice, fileStream);
        //whiteHeadTexture = Content.Load<Texture2D>("white-head");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        Time.Delta = gameTime.ElapsedGameTime;
        Time.Total = gameTime.TotalGameTime;
        _graphics.GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        _spriteBatch.Draw(whiteHeadTexture, new Vector2(0, 0), Color.White);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}