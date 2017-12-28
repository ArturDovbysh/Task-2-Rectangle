using System;
using System.Collections.Generic;

using Task_2_ArturDovbysh.Rectangle.Enums;
using Task_2_ArturDovbysh.Point;

namespace Task_2_ArturDovbysh.Rectangle.Classes
{

    static class DirectionMapper
    {
        public static Dictionary<Direction, Func<Point2D, int, Point2D>> DirectionMap = new Dictionary<Direction, Func<Point2D, int, Point2D>>()
        {
            {
                Direction.Left, (T,T2) => {return new Point2D(T.X - T2, T.Y); }
            },

            {
                Direction.Right, (T,T2) =>{return new Point2D(T.X + T2, T.Y); }
            },

            {
                Direction.Top, (T,T2) =>{ return new Point2D(T.X, T.Y + T2); }
            },

            {
                Direction.Bottom, (T,T2) =>{ return new Point2D(T.X, T.Y - T2); }
            },

            {
                Direction.TopLeft, (T,T2) => { return new Point2D(T.X - T2, T.Y + T2); }
            },

            {
                Direction.TopRight, (T,T2) => { return new Point2D(T.X + T2, T.Y + T2); }
            },

            {
                Direction.BottomLeft, (T,T2) => { return new Point2D(T.X-T2 , T.Y - T2); }
            },

            {
                Direction.BottomRight, (T,T2) => { return new Point2D(T.X + T2, T.Y - T2); }
            }
        };

    }
}
