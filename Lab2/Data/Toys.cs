

namespace Lab2.Data
{
    class Toy
    {
        public string size { get; set; }
        public int cost { get; set; }

    }

    class Doll : Toy
    {
        static string name = "Doll";

        public Doll(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
        }
    }

    class Cube : Toy
    {
        static string name = "Cube";
        public Cube(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
        }
    }

    class ToyCar : Toy
    {
        static string name = "Car";

        public ToyCar(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
        }
    }


}

