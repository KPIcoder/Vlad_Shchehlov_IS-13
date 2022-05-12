

namespace Lab2.Data
{
    class Toy
    {
        public string size { get; set; }
        public int cost { get; set; }
        public string name { get; set; }

    }

    class Doll : Toy
    {
     

        public Doll(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
            this.name = "Doll";
        }
    }

    class Cube : Toy
    {
        public Cube(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
            this.name = "Cube";
        }
    }

    class ToyCar : Toy
    {

        public ToyCar(string size, int cost)
        {
            this.size = size;
            this.cost = cost;
            this.name = "Car";
        }
    }


}

