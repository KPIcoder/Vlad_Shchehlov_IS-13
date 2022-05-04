
namespace Lab2.Data
{
    class Car
    {
        public string name { get; set; }
        private Wheel[] _wheels;
        private Engine _engine;
        
        public void drive()
        {
            Console.WriteLine("All set, let`s go");
        }
        public void refueling()
        {
            Console.WriteLine("Refueling...");
            Thread.Sleep(5000);
            Console.WriteLine("Refueled");
        }
        public void printName()
        {
            Console.WriteLine($"Car name: {name}");
        }
        public void changeWheel()
        {
            Console.WriteLine("Choose wheel number (1-4)");
            string sWheelNumber = Console.ReadLine();
            int wheelNumber = int.Parse(sWheelNumber);
            if (wheelNumber > 4 || wheelNumber < 1)
            {
                Console.WriteLine("Car don`t have this wheel");
                return;
            }
            _wheels[wheelNumber - 1] = new Wheel();
        }
        public Car(string nname)
        {
            _engine = new Engine();
            _wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
                _wheels[i] = new Wheel();
            name = nname;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Car tmp = (Car) obj;
            return this.name == tmp.name;
        }
        public override int GetHashCode() => name.GetHashCode();
        public override string ToString()
        {
            return string.Format("Name: {0}", name);
        }

    }
}
