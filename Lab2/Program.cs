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

            ToysPool pool = new ToysPool();
            pool.AddToy(new Doll("Medium", 100, 3, 7));
            pool.AddToy(new Doll("Small", 50, 10, 15));
            pool.AddToy(new Doll("Medium", 150, 6, 9));
            pool.AddToy(new Doll("Large", 200, 5, 10));
            pool.AddToy(new ToyCar("Small", 100, 3, 7));
            pool.AddToy(new ToyCar("Small", 50, 10, 15));
            pool.AddToy(new ToyCar("Medium", 150, 6, 9));
            pool.AddToy(new ToyCar("Large", 200, 5, 10));
            pool.AddToy(new Cube("Large", 200, 5, 10));
            pool.AddToy(new Cube("Large", 200, 5, 10));
            Playroom playroom2 = new Playroom(800, 0, 100);
            playroom2.fillPlayroom(pool);


            Console.WriteLine("\nPlayroom\n");
            playroom2.PrintDetails();
        }
    }
}