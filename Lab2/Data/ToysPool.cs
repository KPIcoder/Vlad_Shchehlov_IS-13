namespace Lab2.Data
{
    class ToysPool
    {
        public List<Toy> allToys { get; private set; } = new List<Toy>();

        public void AddToy(Toy toy)
        {
            allToys.Add(toy); 
        }
    }
}
