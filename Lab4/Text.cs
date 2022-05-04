using System.Drawing;

namespace Lab4
{
    abstract class Text
    {
        public string text { get; protected set; } = string.Empty;
        protected Color _color;
        protected string _font = "";
        public uint charNumber
        {
            get
            {
                return (uint)text.Length;
            }
            set { }
        }

        protected Text(uint charNum, Color color, string font)
        {
            charNumber = charNum;
            _color = color;
            _font = font;
        }

        protected Text(Color color, string font)
        {
            _color = color;
            _font = font;
        }

        protected Text(string text, Color color, string font)
        {
            this.text = text;
            _color = color;
            _font = font;
        }

        public void PrintColor()
        {
            Console.WriteLine(_color.ToString().Split("[")[1].Split("]")[0]);
        }
        public void PrintFont()
        {
            Console.WriteLine(_font);
        }
        public virtual void PrintPagesNumber() => Console.WriteLine("No pages in this type of text!");
    }
}
