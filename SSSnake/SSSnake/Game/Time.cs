using System;

namespace SSSnake;

public class Time
{
    public static TimeSpan Total = TimeSpan.Zero;

    /// <summary>
    /// The delta time between two update/draw.
    /// </summary>
    public static TimeSpan Delta = TimeSpan.Zero;
}