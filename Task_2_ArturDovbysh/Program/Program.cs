using System;

using Task_2_ArturDovbysh.Point;
using Task_2_ArturDovbysh.Rectangle.Enums;
using Task_2_ArturDovbysh.Rectangle.Classes;

namespace Task_2_ArturDovbysh
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDemo();
        }


        static void RunDemo()
        {
            try
            {
                CreationDemo();
                MovingDemo();
                FunctionsDemo();
            }
            catch (Exception e)
            {
                Console.WriteLine("Demo error : {0}, in {1}", e.Message, e.TargetSite);
            }
        }

        static void CreationDemo()
        {
            Console.WriteLine("Creation Demo");
            try
            {
                MyRectangle rect1 = new MyRectangle(new Point2D(4, 4), 4, 4);
                Console.WriteLine("Rectangle 1 was created with next parameters.");

                PrintfRectInfo(rect1);

            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-', 30));
        }

        static void MovingDemo()
        {
            Console.WriteLine("Moving Demo");

            try
            {
                Console.WriteLine("Lets move rectangle 1 to the top right corner by 10.");
                MyRectangle rect1 = new MyRectangle(new Point2D(4, 4), 4, 4);

                rect1.Move(Direction.TopRight, 10);

                PrintfRectInfo(rect1);

                Console.WriteLine();

                Console.WriteLine("Lets move rectangle 1 to the previous position.");

                rect1.Move(Direction.BottomLeft, 10);

                PrintfRectInfo(rect1);

            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-', 30));

        }

        static void FunctionsDemo()
        {
            Console.WriteLine("Functions Demo");
            try
            {
                MyRectangle rect1 = new MyRectangle(new Point2D(4, 4), 4, 4);
                MyRectangle rect2 = new MyRectangle(new Point2D(3, 6), 10, 10);

                Console.WriteLine("Rectangle 2 was created with next parameters.");

                PrintfRectInfo(rect2);

                Console.WriteLine();

                Console.WriteLine("Lets get intersection of rectangle 1 and 2");

                MyRectangle rect3 = MyRectangle.BuildIntersection(rect1, rect2);

                Console.WriteLine("As a result rectangle 3 was created with next parameters.");

                PrintfRectInfo(rect3);

                Console.WriteLine();

                Console.WriteLine("Lets build container for rectangle 1 and 2");

                MyRectangle rect4 = MyRectangle.BuildContainerRect(rect1, rect2);

                Console.WriteLine("As a result rectangle 4 was created with next parameters.");

                PrintfRectInfo(rect4);

            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine(new string('-', 30));
        }

        static void PrintfRectInfo(MyRectangle rect)
        {
            Console.WriteLine($"Top left point : (X,Y) = ({rect.Peak.X},{rect.Peak.Y})");
            Console.WriteLine($"Width : {rect.Width} Height : {rect.Height}");
            Console.WriteLine($"Square : {rect.GetSquare()} Perimeter : {rect.GetPerimeter()}");
        }
    }

}
