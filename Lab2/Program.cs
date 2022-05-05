namespace Lab2.Data
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car("Mers");
            Car cr1 = new Car("Mers");
            cr.drive();
            cr.refueling();
            cr.changeWheel();
            cr.printName();
            Console.WriteLine (cr.Equals(cr1));
            Console.WriteLine(cr.GetHashCode());
            Console.WriteLine(cr.ToString());
        }
    }
}