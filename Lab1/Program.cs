using System;
using Newtonsoft.Json;

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x1, x2, y1, y2, x3, x4, y3, y4;
            string sx1, sx2, sy1, sy2, sx3, sx4, sy3, sy4, askMove, askChangeCoords;
            Console.WriteLine("First rectangle");
            Console.WriteLine("Enter x1");
            sx1 = Console.ReadLine();
            Console.WriteLine("Enter x2");
            sx2 = Console.ReadLine();
            Console.WriteLine("Enter y1");
            sy1 = Console.ReadLine();
            Console.WriteLine("Enter y2");
            sy2 = Console.ReadLine();
            Console.WriteLine("Second rectangle");
            Console.WriteLine("Enter x3");
            sx3 = Console.ReadLine();
            Console.WriteLine("Enter x4");
            sx4 = Console.ReadLine();
            Console.WriteLine("Enter y3");
            sy3 = Console.ReadLine();
            Console.WriteLine("Enter y4");
            sy4 = Console.ReadLine();

            x1 = int.Parse(sx1);
            x2 = int.Parse(sx2);
            if (x1 > x2)
            {
                int k = x1;
                x1 = x2;
                x2 = k;
            }
            y1 = int.Parse(sy1);
            y2 = int.Parse(sy2);
            if (y1 > y2)
            {
                int k = y1;
                y1 = y2;
                y2 = k;
            }
            x3 = int.Parse(sx3);
            x4 = int.Parse(sx4);
            if (x3 > x4)
            {
                int k = x3;
                x3 = x4;
                x4 = k;
            }
            y3 = int.Parse(sy3);
            y4 = int.Parse(sy4);
            if (y3 > y4)
            {
                int k = y3;
                y3 = y4;
                y4 = k;
            }

            var Rectangles = new SpecialRectangles(x1, x2, y1, y2, x3, x4, y3, y4);
            Rectangles.PrintAllDetails();

            Console.WriteLine("Do you want to move the rectangles? (+)");
            askMove = Console.ReadLine();
            if (askMove == "+")
            {
                string SmoveX, SmoveY;
                int moveX, moveY;
                Console.WriteLine("Move by x:");
                SmoveX = Console.ReadLine();
                Console.WriteLine("Move by y:");
                SmoveY = Console.ReadLine();
                moveX = int.Parse(SmoveX);
                moveY = int.Parse(SmoveY);
                Rectangles.MoveX(moveX);
                Rectangles.MoveY(moveY);
                Rectangles.PrintAllDetails();
            }
            Console.WriteLine("Do you want to change rectangle coordinates? (+)");
            askChangeCoords = Console.ReadLine();
            if (askChangeCoords == "+")
            {
                string newSx1, newSx2, newSy1, newSy2, newSx3, newSx4, newSy3, newSy4;
                int changeX1, changeX2, changeY1, changeY2, changeX3, changeX4, changeY3, changeY4;
                Console.WriteLine("First rectangle");
                Console.WriteLine("Enter new x1");
                newSx1 = Console.ReadLine();
                Console.WriteLine("Enter new x2");
                newSx2 = Console.ReadLine();
                Console.WriteLine("Enter new y1");
                newSy1 = Console.ReadLine();
                Console.WriteLine("Enter new y2");
                newSy2 = Console.ReadLine();
                Console.WriteLine("Second rectangle");
                Console.WriteLine("Enter new x3");
                newSx3 = Console.ReadLine();
                Console.WriteLine("Enter new x4");
                newSx4 = Console.ReadLine();
                Console.WriteLine("Enter new y3");
                newSy3 = Console.ReadLine();
                Console.WriteLine("Enter new y4");
                newSy4 = Console.ReadLine();
                changeX1 = int.Parse(newSx1);
                changeX2 = int.Parse(newSx2);
                changeY1 = int.Parse(newSy1);
                changeY2 = int.Parse(newSy2);
                changeX3 = int.Parse(newSx3);
                changeX4 = int.Parse(newSx4);
                changeY3 = int.Parse(newSy3);
                changeY4 = int.Parse(newSy4);
                Rectangles.ChangeCoordinates(changeX1, changeX2, changeY1, changeY2, changeX3, changeX4, changeY3, changeY4);
                Rectangles.PrintAllDetails();
            }

            Console.Write("Outer Area Of 2 Rectangles: ");
            Console.WriteLine(Rectangles.OuterAreaOf2Rectangles());
            Console.Write("Inner Area Of 2 Rectangles: ");
            Console.WriteLine(Rectangles.InnerAreaOf2Rectangles());
            Rectangles.serialiseToJSON();
            var newRecs = Rectangles.deserialiseFromJSON();
            Console.WriteLine("\nDeserialised object\n");
            newRecs.PrintAllDetails();


        }
    }
}
