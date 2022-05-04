using System.Drawing;

namespace Lab4
{
    class PaperBook : Text
    {
        public uint pagesNumber { get; set; }
        public Page[] pages;

        public override void PrintPagesNumber()
        {
            Console.Write(pagesNumber);
        }

        public PaperBook(uint pagesNum, Color color, string font) 
                        : base(color, font)
        {
            this.pagesNumber = pagesNum;
            pages = new Page[pagesNum];
            for (int i = 0; i < pagesNum; i++)
            {
                pages[i] = new Page(i + 1, "test" + (i + 1).ToString());
                base.charNumber += pages[i].countChars();
                base.text += pages[i].Text + "\n\t" + (i + 1).ToString() + "\n\n";
            }
        }
    }
    class Page
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public Page( int number, string txt)
        {
            this.Number = number;
            this.Text = txt;
        }
        public uint countChars()
        {
            return (uint)Text.Length;
        } 
    }
    class Ebook : Text
    {
        public Ebook(uint charNumber, Color color, string font)
                     : base(charNumber, color, font) { }

        public void TransferToFlashdrive(string path)
        {
            Console.WriteLine("\nCopying data...");
            Thread.Sleep(3000);
            Console.WriteLine("Data has been transfered succefully");
        }
    }
    class Graffiti : Text
    {
        public Graffiti(string text, Color color, string font)
                       : base(text, color, font) { }
        public void Erase()
        {
            base.text = string.Empty;
        }
    }
}
