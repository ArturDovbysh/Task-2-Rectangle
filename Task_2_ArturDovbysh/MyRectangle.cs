using System;

namespace Task_2_ArturDovbysh
{
    /// <summary>
    /// Represents a rectangle on the square
    /// </summary>
    public class MyRectangle : IFigure2D
    {
        private int _width;
        private int _height;

        /// <summary>
        /// Returns the peak of rectangle.
        /// </summary>
        public Point2D Peak { get; private set; }

        /// <summary>
        /// Returns width of current rectangle.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException();

                _width = value;
            }
        }

        /// <summary>
        /// Returns height of current rectangle.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException();

                _height = value;
            }
        }

        /// <summary>
        /// Moves the rectangle in the specified direction on specified length.
        /// </summary>
        /// <param name="direction">Move direction.</param>
        /// <param name="length">Length of moving.</param>
        public void Move(Direction direction, int length)
        {
            if (length < 0)
                throw new ArgumentException();

            switch (direction)
            {
                case Direction.Left:
                    Peak = new Point2D(Peak.X - length, Peak.Y);
                    break;
                case Direction.Right:
                    Peak = new Point2D(Peak.X + length, Peak.Y);
                    break;
                case Direction.Top:
                    Peak = new Point2D(Peak.X, Peak.Y + length);
                    break;
                case Direction.Bottom:
                    Peak = new Point2D(Peak.X, Peak.Y - length);
                    break;
                case Direction.TopLeft:
                    Peak = new Point2D(Peak.X - length, Peak.Y + length);
                    break;
                case Direction.TopRight:
                    Peak = new Point2D(Peak.X + length, Peak.Y + length);
                    break;
                case Direction.BottomLeft:
                    Peak = new Point2D(Peak.X - length, Peak.Y - length);
                    break;
                case Direction.BottomRight:
                    Peak = new Point2D(Peak.X + length, Peak.Y - length);
                    break;
                default: break;
            }
        }

        /// <summary>
        /// Returns square of the rectangle.
        /// </summary>
        /// <returns></returns>
        public int GetSquare()
        {
            return Width*Height;
        }

        /// <summary>
        /// Returns perimeter of the rectangle.
        /// </summary>
        /// <returns></returns>
        public int GetPerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        /// <summary>
        /// Returns a new rectangle that contains in two specified rectangles.
        /// </summary>
        /// <param name="rect1">First rectangle.</param>
        /// <param name="rect2">Second rectangle.</param>
        /// <returns>New rectangle.</returns>
        public static MyRectangle BuildContainerRect(MyRectangle rect1, MyRectangle rect2)
        {
            if (rect1 is null || rect2 is null)
                throw new ArgumentNullException();

            //select top left point

            //select the smallest x.
            int x = Math.Min(rect1.Peak.X, rect2.Peak.X);

            //select the greatest y.
            int y = Math.Max(rect1.Peak.Y, rect2.Peak.Y);

            //bottom right
            int width = 2*Math.Abs(Math.Max(rect1.Width, rect2.Width) - Math.Min(rect1.Width, rect2.Width));
            int height = 2*Math.Abs(Math.Max(rect1.Height, rect2.Height)  - Math.Min(rect1.Height, rect2.Height));

            return new MyRectangle(new Point2D(x, y), width, height);
        }

        /// <summary>
        /// Returns a new rectangle as a result of intersection of two rectangles.
        /// </summary>
        /// <param name="rect1">First rectangle.</param>
        /// <param name="rect2">Second rectangle.</param>
        /// <returns>New rectangle.</returns>
        public static MyRectangle BuildIntersection(MyRectangle rect1, MyRectangle rect2)
        {
            if (rect1 is null || rect2 is null)
                throw new ArgumentNullException();

            if(rect1.Intersects(rect2))
            {
                int rigthSide = Math.Min(rect1.Peak.X + rect1.Width, rect2.Peak.X + rect2.Width);
                int leftSide = Math.Max(rect1.Peak.X, rect2.Peak.X);
                int topSide = Math.Min(rect1.Peak.Y, rect2.Peak.Y);
                int bottomSide = Math.Min(rect1.Peak.Y + rect1.Height, rect2.Peak.Y + rect2.Height);
                return new MyRectangle(new Point2D(leftSide, topSide), rigthSide - leftSide, bottomSide - topSide);
                
            }
            else
            {
                return new MyRectangle();
            }

        }

        /// <summary>
        /// Checks if the rectangle intersects with other specified rectangle.
        /// </summary>
        /// <param name="rect">Rectangle to check.</param>
        /// <returns>True - if yes; otherwise - false.</returns>
        public bool Intersects(MyRectangle rect)
        {
            return rect.Peak.X < this.Peak.X + this.Width&&
                this.Peak.X < rect.Peak.X + rect.Width &&
                rect.Peak.Y < this.Peak.Y + this.Height &&
                this.Peak.Y < rect.Peak.Y + rect.Height;

        }

        /// <summary>
        /// Initializes a new empty rectangle.
        /// </summary>
        public MyRectangle()
        {
            Peak = new Point2D(0, 0);
            Width = 0;
            Height = 0;
        }

        /// <summary>
        /// Initializes a new rectangle with specified start point , width and height.
        /// </summary>
        /// <param name="start">Peak of the rectangle (top left point).</param>
        /// <param name="width">Width of the rectangle.</param>
        /// <param name="height">Height of the rectangle.</param>
        public MyRectangle(Point2D start, int width, int height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentException();

            Width = width;
            Height = height;
            Peak = start;
        }

        /// <summary>
        /// Initializes a new rectangle with specified width and height.
        /// </summary>
        /// <param name="width">Width of the rectangle.</param>
        /// <param name="height">Height of the rectangle.</param>
        public MyRectangle(int width, int height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentException();

            Width = width;
            Height = height;
            Peak = new Point2D(0, 0);
        }

    }
}
