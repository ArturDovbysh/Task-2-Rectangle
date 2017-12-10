using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_ArturDovbysh
{
    /// <summary>
    /// Represents a simple 2D point in Dekart system.
    /// </summary>
    public struct Point2D
    {
        /// <summary>
        /// Returns or sets X coordinate of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Returns or sets Y coordinate of the point.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Initializes a new point with specified two coordinates.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
