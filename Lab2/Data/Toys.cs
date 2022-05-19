

namespace Lab2.Data
{
    class Toy
    {
        public string size { get; set; } = "";
        public int cost { get; set; }
        public string name { get; set; } = "";
        public int minAge { get; set; }
        public int maxAge { get; set; }

    }

    class Doll : Toy
    {
     

        public Doll(string size, int cost, int minAge, int maxAge)
        {
            this.size = size;
            this.cost = cost;
            this.minAge = minAge;
            this.maxAge = maxAge;   
            this.name = "Doll";
        }
    }

    class Cube : Toy
    {
        public Cube(string size, int cost, int minAge, int maxAge)
        {
            this.size = size;
            this.cost = cost;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.name = "Cube";
        }
    }

    class ToyCar : Toy
    {

        public ToyCar(string size, int cost, int minAge, int maxAge)
        {
            this.size = size;
            this.cost = cost;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.name = "Car";
        }
    }


}

