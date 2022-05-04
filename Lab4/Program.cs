using System.Drawing;
namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text ebook = new Ebook(250, Color.White, "Timew New Roman");
            Text book = new PaperBook(10, 250, Color.White, "Timew New Roman");
            Console.WriteLine(book.charNumber);
        }
    }
}
