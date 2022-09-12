using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SSSnake.Components;

public abstract class DrawableEntityComp : EntityComp, IDrawable
{
    private bool _initialized;
    private bool _disposed;
    private int _drawOrder;
    private bool _visible = true;

    public GraphicsDevice GraphicsDevice => Vars.Game.GraphicsDevice;

    public int DrawOrder
    {
        get => _drawOrder;
        set
        {
            if (_drawOrder == value)
                return;
            _drawOrder = value;
            OnDrawOrderChanged(this, EventArgs.Empty);
        }
    }

    public bool Visible
    {
        get => _visible;
        set
        {
            if (_visible == value)
                return;
            _visible = value;
            OnVisibleChanged(this, EventArgs.Empty);
        }
    }

    public event EventHandler<EventArgs> DrawOrderChanged;

    public event EventHandler<EventArgs> VisibleChanged;

    public override void Initialize()
    {
        if (_initialized)
            return;
        _initialized = true;
        LoadContent();
    }

    protected override void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        _disposed = true;
        UnloadContent();
    }

    protected virtual void LoadContent()
    {
    }

    protected virtual void UnloadContent()
    {
    }

    public abstract void Draw(GameTime gameTime);

    protected virtual void OnVisibleChanged(object sender, EventArgs args)
    {
        VisibleChanged?.Invoke(sender, args);
    }

    protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
    {
        DrawOrderChanged?.Invoke(sender, args);
    }
}