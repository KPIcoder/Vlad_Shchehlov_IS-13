using System.Drawing;
namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text book1 = new PaperBook(5, Color.Black, "Montserrat");
            Text ebook = new Ebook(Color.White, "Timew New Roman");
            Text book = new PaperBook(2, Color.White, "Timew New Roman");
            Text gf = new Graffiti("Proga", Color.White, "Arial");
            Console.WriteLine("ebook");
            ebook.PrintColor();
            ebook.PrintFont();
            Console.WriteLine(ebook.getPagesNumber());
            ((Ebook)ebook).TransferToFlashdrive("c:\\");
            Console.WriteLine("\n\ngraffiti");
            gf.PrintColor();
            gf.PrintFont();
            Console.WriteLine(gf.getPagesNumber());
            Console.WriteLine("Chars -> ");
            Console.WriteLine(gf.charNumber);
            ((Graffiti)gf).Erase();
            Console.WriteLine("Deleting chars -> ");
            Console.Write(gf.charNumber);
            Console.WriteLine("\n\npaperbook");
            book.PrintColor();
            book.PrintFont();
            Console.WriteLine("Number of pages: ");
            Console.WriteLine(book.getPagesNumber());
            Console.WriteLine("\nNumber of chars: ");
            Console.WriteLine(book.charNumber);
            VirtualLibrary vr = new VirtualLibrary(book1);
            vr.AddText(gf);
            vr.AddText(book);
            vr.AddText(ebook);
            Console.WriteLine(vr.getTotalCharNumber());
            Console.WriteLine(vr.getTotalPagesNumber());
        }
    }
}
