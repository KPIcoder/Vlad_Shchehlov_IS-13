

namespace Lab4
{
    class VirtualLibrary
    {
        private List<Text> _texts = new List<Text>();
        public VirtualLibrary(Text newText) 
        {
            _texts = new List<Text>();
            _texts.Add(newText);
        }

        public uint getTotalCharNumber()
        {
            uint cnt = 0;
            for (int i = 0; i < _texts.Count; i++)
            {
                cnt += _texts[i].charNumber;
            }
            return cnt;
        }

        public uint getTotalPagesNumber()
        {
            uint cnt = 0;
            uint pagesNum = 0;
            bool isPaperBook = false;
            for (int i = 0; i < _texts.Count; i++)
            {
                isPaperBook = uint.TryParse(_texts[i].getPagesNumber(), out pagesNum);
                if(isPaperBook)
                    cnt += pagesNum; 
            }

            return cnt;
        }

        public void AddText(Text newText)
        {
            _texts.Add(newText);
        }
    }
}
