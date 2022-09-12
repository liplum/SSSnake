#nullable enable
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using SSSnake.Entities;

namespace SSSnake;

public class GameObject
{
    private static int _globalId;
    public int Id = _globalId++;
    public bool IsAdded { get; private set; }

    public virtual void Add()
    {
        if (!IsAdded)
        {
            IsAdded = true;
        }
    }

    private readonly Dictionary<Type, IGameComponent> _components = new();

    protected void AddComp<T>(T comp) where T : IGameComponent
    {
        _components[typeof(T)] = comp;
    }

    public virtual void InitComponents()
    {
    }

    public T? GetComponent<T>() where T : class, IGameComponent
    {
        return _components[typeof(T)] as T;
    }
}