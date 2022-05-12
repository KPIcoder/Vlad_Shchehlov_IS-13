using Newtonsoft.Json;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter N:");
            string sN = Console.ReadLine();
            int N = int.Parse(sN);
            List<int> nums = new List<int>();

            for (int i = 0; i < N; i++)
            {
                nums.Add(i + 1);
            }
            int n = 2;
            for (int i = n; i < nums.Count; i += n * 2)
            {
                nums.Reverse(i, n);
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i].ToString() + '\t');
                if ((i + 1) % n == 0)
                    Console.WriteLine("\n");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 2");

            var testlist = new List<string>();
            var testdictionary = new Dictionary<int, string>()
            {
                [1] = "word",
                [2] = "draw",
                [3] = "add",
                [4] = "hello",
                [5] = "world",
            };
            foreach (var word in testdictionary)
            {
                testlist.Add(word.Value);
            }
            testlist.Sort();
            foreach (var word in testlist)
            {
                Console.WriteLine(word);
            }
            string JSONdict = JsonConvert.SerializeObject(testdictionary);
            string path = @"D:\Прога 2-й семестр\Labs_2nd_term\Lab3\dictionary.json";
            if(!File.Exists(path))
                File.Create(path).Close();
            File.WriteAllText(path, JSONdict);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 3");
            string[] A = { "jskfhlasfdsof", "oksfdhshfa", "fksfkdsfhfjs", "hello", "proga" };
            var firstChars = (from str in A
                             select str[0]).Reverse();
            foreach (char cr in firstChars)
            {
                Console.Write(cr + " ");
            }
        }
    }
}
