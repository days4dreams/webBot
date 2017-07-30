using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace webBot
{
    public class Math
    {
        public int CountCharacters (string analyse)
        {
            int count = 0;
            foreach (char character in analyse)
            {
                count++;
            }
            return count;
        }
    }
}
