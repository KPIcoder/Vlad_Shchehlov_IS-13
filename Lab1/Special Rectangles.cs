using Newtonsoft.Json;

namespace Lab1
{
    class SpecialRectangles
    {
        public int x1, x2, y1, y2, x3, x4, y3, y4; // coordinates

        public void MoveX(int xToMove)
        {
            x1 += xToMove;
            x2 += xToMove;
            x3 += xToMove;
            x4 += xToMove;
        }
        public void MoveY(int yToMove)
        {
            y1 += yToMove;
            y2 += yToMove;
            y3 += yToMove;
            y4 += yToMove;

        }
        public void ChangeCoordinates(int newX1, int newX2, int newY1, int newY2, int newX3, int newX4, int newY3, int newY4)
        {
            x1 = newX1;
            x2 = newX2;
            y1 = newY1;
            y2 = newY2;
            x3 = newX3;
            x4 = newX4;
            y3 = newY3;
            y4 = newY4;
        }
        public void PrintAllDetails()
        {
            Console.WriteLine($"Coordinates of the first rectangle: ({x1};{y1})  ({x1};{y2})  ({x2};{y2})  ({x2};{y1})");
            Console.WriteLine("Height: " + Math.Abs(y2 - y1));
            Console.WriteLine("Length: " + Math.Abs(x2 - x1));
            Console.WriteLine($"Coordinates of the second rectangle: ({x3};{y3})  ({x3};{y4})  ({x4};{y4})  ({x4};{y3})");
            Console.WriteLine("Height: " + Math.Abs(y4 - y3));
            Console.WriteLine("Length: " + Math.Abs(x4 - x3));
        }
        public int OuterAreaOf2Rectangles()
        {
            int outerX1, outerY1, outerX2, outerY2;
            if (x1 > x3)
                outerX1 = x3;
            else
                outerX1 = x1;
            if (x2 > x4)
                outerX2 = x2;
            else
                outerX2 = x4;
            if (y1 > y3)
                outerY1 = y3;
            else
                outerY1 = y1;
            if (y2 > y4)
                outerY2 = y2;
            else
                outerY2 = y4;
            return Math.Abs(outerX2 - outerX1) * Math.Abs(outerY1 - outerY2);
        }
        public int InnerAreaOf2Rectangles()
        {
            int innerX1, innerY1, innerX2, innerY2;
            if ((x1 > x4 || x2 < x3) && (y1 > y4 || y2 < y3))
                return 0;
            else if ((x3 > x2 || x4 < x1) && (y3 > y2 || y4 < y1))
                return 0;
            innerX1 = Math.Max(x1, x3);
            innerX2 = Math.Min(x2, x4);
            innerY1 = Math.Max(y1, y3);
            innerY2 = Math.Min(y2, y4);
            return Math.Abs(innerX2 - innerX1) * Math.Abs(innerY2 - innerY1);
        }
        public void serialiseToJSON()
        {
            string path = @"D:\Прога 2-й семестр\Labs_2nd_term\Lab1\rectangles.json";
            var rectangles = new SpecialRectangles(this.x1, this.x2, this.y1, this.y2, this.x3, this.x4, this.y3, this.y4);
            if (!File.Exists(path))
                File.Create(path).Close();
            string JSONobj = JsonConvert.SerializeObject(rectangles);
            File.WriteAllText(path, JSONobj);
        }
        public SpecialRectangles deserialiseFromJSON()
        {
            string path = @"D:\Прога 2-й семестр\Labs_2nd_term\Lab1\rectangles.json";
            if (!File.Exists(path))
                return null;
            var rectangles = JsonConvert.DeserializeObject<SpecialRectangles>(File.ReadAllText(path));
            return rectangles;
        }
        public SpecialRectangles(int x1, int x2, int y1, int y2, int x3, int x4, int y3, int y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.x3 = x3;
            this.x4 = x4;
            this.y3 = y3;
            this.y4 = y4;
        }
    }
}
