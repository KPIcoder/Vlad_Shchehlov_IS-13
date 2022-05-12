
namespace Lab2.Data
{
    class Playroom
    {
        Toy[] bigStorage, mediumStorage, smallStorage;
        Toy[] toys;
        static int count = 30;
        public int money { get; set; }
        public int age { get; set; }

        public Playroom(int money, int age)
        {
            this.money = money;
            this.age = age;
            bigStorage = new Toy[count];
            mediumStorage = new Toy[count];
            smallStorage = new Toy[count];
            for (int i = 0; i < count; i++)
            {
                if (i < 10)
                {
                    bigStorage[i] = new ToyCar("big", 200);
                    mediumStorage[i] = new ToyCar("medium", 100);
                    smallStorage[i] = new ToyCar("small", 50);
                }
                else if (i < 20)
                {
                    bigStorage[i] = new Cube("big", 200);
                    mediumStorage[i] = new Cube("medium", 100);
                    smallStorage[i] = new Cube("small", 50);
                }
                else
                {
                    bigStorage[i] = new Doll("big", 200);
                    mediumStorage[i] = new Doll("medium", 100);
                    smallStorage[i] = new Doll("small", 50);
                }
            }
        }
        public void fillPlayroom()
        {

            var rand = new Random();
            if (age > 6 && money >= 9000)
            {
                toys = new Toy[2 * count];
                for (int i = 0; i < count; i++)
                {
                    toys.Append(bigStorage[i]);
                    toys.Append(mediumStorage[i]);
                }
            }
            if (age <= 6 && money >= 4500)
            {
                toys = new Toy[2 * count];
                for (int i = 0; i < count; i++)
                {
                    toys.Append(mediumStorage[i]);
                    toys.Append(smallStorage[i]);
                }
            }
            if (age > 6)
            {
                int toysCount = (money <= 6000) ? money / bigStorage[0].cost : 30 + (money - 6000) / mediumStorage[0].cost;
                toys = new Toy[toysCount];
                int i = 0;
                while (money >= mediumStorage[0].cost)
                {
                    if (bigStorage.Length > 0 && money >= bigStorage[0].cost)
                    {
                        int randomIndex = rand.Next(bigStorage.Length);
                        toys[i] = bigStorage[randomIndex];
                        money -= bigStorage[0].cost;
                        bigStorage = bigStorage.Where((source, index) => index != randomIndex).ToArray();
                    }
                    else if (money >= mediumStorage[0].cost)
                    {
                        int randomIndex = rand.Next(mediumStorage.Length);
                        toys[i] = mediumStorage[randomIndex];
                        money -= mediumStorage[0].cost;
                        mediumStorage = mediumStorage.Where((source, index) => index != randomIndex).ToArray();
                    }
                    i++;
                }
            }
            else if (age <= 6)
            {
                int toysCount = (money <= 3000) ? money / mediumStorage[0].cost : 30 + (money - 3000) / smallStorage[0].cost;
                toys = new Toy[toysCount];
                int i = 0;
                while (money >= smallStorage[0].cost)
                {
                    if (mediumStorage.Length > 0 && money >= mediumStorage[0].cost)
                    {
                        int randomIndex = rand.Next(mediumStorage.Length);
                        toys[i] = mediumStorage[randomIndex];
                        money -= mediumStorage[0].cost;
                        mediumStorage = mediumStorage.Where((source, index) => index != randomIndex).ToArray();
                    }
                    else
                    {
                        int randomIndex = rand.Next(smallStorage.Length);
                        toys[i] = smallStorage[randomIndex];
                        money -= smallStorage[0].cost;
                        smallStorage = smallStorage.Where((source, index) => index != randomIndex).ToArray();
                    }
                    i++;
                }
            }
        }
        public void PrintDetails()
        {
            for (int i = 0; i < toys.Length; i++)
            {
                Console.WriteLine($"Toy:{toys[i].name} {toys[i].size} - {toys[i].cost}");
            }
        }
    }
}
