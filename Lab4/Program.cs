using System.Drawing;
namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text ebook = new Ebook(250, Color.White, "Timew New Roman");
            Text book = new PaperBook(2, Color.White, "Timew New Roman");
            Text gf = new Graffiti("Proga", Color.White, "Arial");
            Console.WriteLine("ebook");
            ebook.PrintColor();
            ebook.PrintFont();
            ebook.PrintPagesNumber();
            ((Ebook)ebook).TransferToFlashdrive("c:\\");
            Console.WriteLine("\n\ngraffiti");
            gf.PrintColor();
            gf.PrintFont();
            gf.PrintPagesNumber();
            Console.WriteLine("Chars -> ");
            Console.WriteLine(gf.charNumber);
            ((Graffiti)gf).Erase();
            Console.WriteLine("Deleting chars -> ");
            Console.Write(gf.charNumber);
            Console.WriteLine("\n\npaperbook");
            book.PrintColor();
            book.PrintFont();
            Console.WriteLine("Number of pages: ");
            book.PrintPagesNumber();
            Console.WriteLine("\nNumber of chars: ");
            Console.Write(book.charNumber);
        }
    }
}
