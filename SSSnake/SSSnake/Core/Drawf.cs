using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.TextureAtlases;
using Vector2 = System.Numerics.Vector2;

namespace SSSnake.Core;

public static class Drawf
{
    public static readonly Vector2 DefaultScale = new(1, 1);
    public static Vector2 Scale = DefaultScale;
    private static SpriteBatch _batch;
    public static SpriteEffects SpriteEffects = SpriteEffects.None;
    public static float ZIndex = Layers.Background;
    public static Color Color = Color.White;

    public static void PushBatch(SpriteBatch batch)
    {
        _batch = batch;
    }

    public static void PopBatch()
    {
        _batch = null;
    }

    public static void Tex(TextureRegion2D region, Vector2 pos)
    {
        _batch.Draw(region.Texture, new Vector2(pos.X - region.Width / 2f, pos.Y - region.Height / 2f), Color);
    }

    public static void Tex(
        TextureRegion2D region, Vector2 pos, float rotation = 0f
    )
    {
        _batch.Draw(
            texture: region.Texture,
            position: pos,
            sourceRectangle: region.Bounds,
            color: Color,
            rotation: rotation,
            origin: new(1, 1),
            scale: Scale,
            effects: SpriteEffects,
            layerDepth: ZIndex
        );
    }

    public static void Tex(
        Texture2D texture, Vector2 pos, float rotation = 0f
    )
    {
        _batch.Draw(
            texture: texture,
            position: pos,
            sourceRectangle: null,
            color: Color,
            rotation: rotation,
            origin: Vector2.Zero,
            scale: Scale,
            effects: SpriteEffects,
            layerDepth: ZIndex
        );
    }
}