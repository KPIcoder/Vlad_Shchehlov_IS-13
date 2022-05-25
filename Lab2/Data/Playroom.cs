using System.Linq;


namespace Lab2.Data
{
    class Playroom
    {
        
        public List<Toy> allToys = new List<Toy>();
        public int money { get; private set; }
        public int minAge { get; set; }
        public int maxAge { get; set; }

        public Playroom(int money, int minAge, int maxAge)
        {
            this.money = money;
            this.minAge = minAge;
            this.maxAge = maxAge;
        }
        

        public void fillPlayroom(ToysPool toysPool)
        {
            List<Toy> sToy = (from toy in toysPool.allToys
                              where toy.minAge >= this.minAge && toy.maxAge <= this .maxAge
                              select toy).ToList();

            sToy.Sort((x, y) => x.cost.CompareTo(y.cost));

            for (int i = 0; i < sToy.Count; i++)
            {
                if(sToy[i].cost > money)
                    break;
                allToys.Add(sToy[i]);
                money -= sToy[i].cost;
            }
        }
        public void PrintDetails()
        {
            for (int i = 0; i < allToys.Count; i++)
            {
                Console.WriteLine($"Toy: {allToys[i].name} {allToys[i].size} - {allToys[i].cost}");
            }
        }
    }
}
