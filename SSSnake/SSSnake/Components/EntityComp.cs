using System;
using Microsoft.Xna.Framework;

namespace SSSnake.Components;

public abstract class EntityComp : IGameComponent, IUpdateable, IDisposable
{
    private bool _enabled = true;
    private int _updateOrder;

    public abstract void Update(GameTime gameTime);

    public bool Enabled
    {
        get => _enabled;
        set
        {
            if (_enabled == value) return;
            _enabled = value;
            OnEnabledChanged(this, EventArgs.Empty);
        }
    }

    public int UpdateOrder
    {
        get => _updateOrder;
        set
        {
            if (_updateOrder == value) return;
            _updateOrder = value;
            OnUpdateOrderChanged(this, EventArgs.Empty);
        }
    }

    public event EventHandler<EventArgs> EnabledChanged;

    public event EventHandler<EventArgs> UpdateOrderChanged;

    ~EntityComp() => Dispose(false);

    public virtual void Initialize()
    {
    }

    protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
    {
        UpdateOrderChanged?.Invoke(sender, args);
    }

    protected virtual void OnEnabledChanged(object sender, EventArgs args)
    {
        EnabledChanged?.Invoke(sender, args);
    }

    protected virtual void Dispose(bool disposing)
    {
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}