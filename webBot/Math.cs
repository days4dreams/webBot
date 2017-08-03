using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;

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

        public string GetLoadingTime(string urlInput)
        {
            Stopwatch stopwatch = new Stopwatch();
            HtmlWeb webPage = new HtmlWeb();

            stopwatch.Start();
            var result = webPage.Load(urlInput);
            stopwatch.Stop();

            return stopwatch.Elapsed.Milliseconds.ToString();
        }

        /* using Stopwatch to time the loading time of the given URL
         * Returns the load time in milliseconds as a string
         * Note use of using System.Diagnostics; */
    }
}
