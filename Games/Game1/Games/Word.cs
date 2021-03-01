using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
   public class Word
    {
        public  string text;
        public  int num;

        public Word(string ntext, int nnum)
        {
            text = ntext;
            num = nnum;
        }

        public  string GetText()
        {
            return text;
        }
        public int GetInt()
        {
            return num;
        }
    }
}
