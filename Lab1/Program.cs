using System;
using Newtonsoft.Json;

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
