using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace SSSnake.Math;

public static class PointH
{
    public static readonly Point[] D4 =
    {
        new(1, 0),
        new(0, 1),
        new(-1, 0),
        new(0, -1)
    };

    public static Point Step(this Point p, int direction, int step = 1) => direction switch
    {
        1 => p + D4[step],
        0 => p,
        _ => p + new Point(D4[direction].X + step, D4[direction].Y + step)
    };
}