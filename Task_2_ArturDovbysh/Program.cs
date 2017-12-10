using System;

namespace Task_2_ArturDovbysh
{
    class Program
    {
        static void Main(string[] args)
        {
            ////creation
            //MyRectangle rect1 = new MyRectangle(new Point2D(4,4),4,4);

            //Console.WriteLine("Rectangle 1 was created with next parameters.");
            //Console.WriteLine($"Top left point : (X,Y) = ({rect1.Peak.X},{rect1.Peak.Y})");
            //Console.WriteLine($"Width : {rect1.Width} Height : {rect1.Height}");
            //Console.WriteLine($"Square : {rect1.GetSquare()} Perimeter : {rect1.GetPerimeter()}");
            //Console.WriteLine(new string('-',20));

            ////moving
            //Console.WriteLine("Lets move rectangle 1 to the top right corner by 10.");

            //rect1.Move(Direction.TopRight, 10);

            //Console.WriteLine($"Top left point after moving : (X,Y) =  ({rect1.Peak.X},{rect1.Peak.Y})");
            //Console.WriteLine(new string('-', 20));

            //Console.WriteLine("Lets move rectangle 1 to the previous position.");

            //rect1.Move(Direction.BottomLeft, 10);

            //Console.WriteLine($"Top left point after moving : (X,Y) =  ({rect1.Peak.X},{rect1.Peak.Y})");
            //Console.WriteLine(new string('-', 20));

            ////intersection
            //MyRectangle rect2 = new MyRectangle(new Point2D(3, 6), 10, 10);

            //Console.WriteLine("Rectangle 2 was created with next parameters.");
            //Console.WriteLine($"Top left point : (X,Y) = ({rect2.Peak.X},{rect2.Peak.Y})");
            //Console.WriteLine($"Width : {rect2.Width} Height : {rect2.Height}");
            //Console.WriteLine($"Square : {rect2.GetSquare()} Perimeter : {rect2.GetPerimeter()}");
            //Console.WriteLine(new string('-', 20));

            //Console.WriteLine("Lets get intersection of rectangle 1 and 2");

            //MyRectangle rect3 = MyRectangle.BuildIntersection(rect1, rect2);

            //Console.WriteLine("As a result rectangle 3 was created with next parameters.");
            //Console.WriteLine($"Top left point : (X,Y) = ({rect3.Peak.X},{rect3.Peak.Y})");
            //Console.WriteLine($"Width : {rect3.Width} Height : {rect3.Height}");
            //Console.WriteLine($"Square : {rect3.GetSquare()} Perimeter : {rect3.GetPerimeter()}");
            //Console.WriteLine(new string('-', 20));

            ////get container
            //Console.WriteLine("Lets build container for rectangle 1 and 2");

            //MyRectangle rect4 = MyRectangle.BuildContainerRect(rect1, rect2);

            //Console.WriteLine("As a result rectangle 4 was created with next parameters.");
            //Console.WriteLine($"Top left point : (X,Y) = ({rect4.Peak.X},{rect4.Peak.Y})");
            //Console.WriteLine($"Width : {rect4.Width} Height : {rect4.Height}");
            //Console.WriteLine($"Square : {rect4.GetSquare()} Perimeter : {rect4.GetPerimeter()}");
            //Console.WriteLine(new string('-', 20));

            //Console.WriteLine("You can try it yourself and have more fun!!!");

            MyRectangle r1 = new MyRectangle(10, 10);
            MyRectangle r2 = new MyRectangle(new Point2D(-1, -2), 15, 15);
            MyRectangle r3 = MyRectangle.BuildIntersection(r1, r2);

            bool isCorrect = r3.Peak.X == 0 && r3.Peak.Y == -8 && r3.Width == 2 && r3.Height == 2;

            Console.WriteLine(r3.Peak.X);
            Console.WriteLine(r3.Peak.Y);
            Console.WriteLine(r3.Width);
            Console.WriteLine(r3.Height);
        }
    }
}
