using System.Drawing;

namespace Lab4
{
    class PaperBook : Text
    {
        public int pagesNumber { get; set; }
        public Page[] pages;

        public override void PrintPagesNumber()
        {
            Console.WriteLine(pagesNumber);
        }

        public PaperBook(int pagesNum, uint charNumber, Color color, string font) 
                        : base(charNumber, color, font)
        {
            this.pagesNumber = pagesNum;
            pages = new Page[pagesNum];
            for (int i = 0; i < pagesNum; i++)
            {
                pages[i] = new Page(i + 1, "test" + (i + 1).ToString());
            }
        }
    }
    class Page
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Page( int Id, string txt)
        {
            this.Id = Id;
            this.Text = txt;
        }
    }
    class Ebook : Text
    {
        public Ebook(uint charNumber, Color color, string font)
                     : base(charNumber, color, font) { }
    }
    class Graffiti : Text
    {
        public Graffiti(uint charNumber, Color color, string font)
                       : base(charNumber, color, font) { }
    }
}

//using System.Drawing;

//namespace Lab4
//{
//    class PaperBook : Text
//    {
//        private uint _charNumber;
//        private Color _color;
//        private string _font;
//        public override uint charNumber
//        {
//            get
//            {
//                return _charNumber;
//            }
//        }

//        public int pagesNumber { get; set; }
//        public Page[] pages;

//        public override void PrintPagesNumber()
//        {
//            Console.WriteLine(pagesNumber);
//        }
//        public override void PrintColor()
//        {
//            Console.WriteLine(_color);
//        }
//        public override void PrintFont()
//        {
//            Console.WriteLine(_font);
//        }
//        public PaperBook(int pagesNum)
//        {
//            this.pagesNumber = pagesNum;
//            for (int i = 0; i < pagesNum; i++)
//            {
//                pages[i] = new Page();
//            }
//        }
//    }
//    class Page
//    {
//        public int Id { get; set; }
//        public string Text { get; set; }
//        public Page()
//        {

//        }
//    }
//    class Ebook : Text
//    {
//        private uint _charNumber;
//        private Color _color;
//        private string _font;

//        public override uint charNumber 
//        { 
//            get
//            {
//                return _charNumber;
//            }
//        }
//        public override void PrintColor()
//        {
//            Console.WriteLine(_color);
//        }
//        public override void PrintFont()
//        {
//            Console.WriteLine(_font);
//        }
//    }
//    class Graffiti : Text
//    {
//        private uint _charNumber;
//        private Color _color;
//        private string _font;
//        public override uint charNumber
//        {
//            get
//            {
//                return _charNumber;
//            }
//        }
//        public override void PrintColor()
//        {
//            Console.WriteLine(_color);
//        }
//        public override void PrintFont()
//        {
//            Console.WriteLine(_font);
//        }
//    }
//}