namespace Lab2.Data
{ 
    class Program
    {
        static void Main(string[] args)
        {
            {


                /*Car cr = new Car("Mers");
                Car cr1 = new Car("Mers");
                cr.drive();
                cr.refueling();
                cr.changeWheel();
                cr.printName();
                Console.WriteLine (cr.Equals(cr1));
                Console.WriteLine(cr.GetHashCode());
                Console.WriteLine(cr1.GetHashCode());
                Console.WriteLine(cr.ToString());*/
            }

            var playroom1 = new Playroom(3500, 4);
            var playroom2 = new Playroom(8000, 10);
            playroom1.fillPlayroom();
            playroom1.PrintDetails();
            Console.WriteLine("\nPlayroom 2\n");
            playroom2.fillPlayroom();
            playroom2.PrintDetails();
        }
    }
}