using System.Drawing;

namespace Lab4
{
    abstract class Text
    {
        protected uint _charNumber;
        protected Color _color;
        protected string _font = "";
        public uint charNumber
        {
            get
            {
                return _charNumber;
            }
        }

        protected Text(uint charNumber, Color color, string font)
        {
            _charNumber = charNumber;
            _color = color;
            _font = font;
        }

        public void PrintColor()
        {
            Console.WriteLine(_color);
        }
        public void PrintFont()
        {
            Console.WriteLine(_font);
        }
        public virtual void PrintPagesNumber() => Console.WriteLine("No pages in this type of text!");
    }
}
