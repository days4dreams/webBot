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

        public int GetLoadingTime(string urlInput)
        {
            Stopwatch stopwatch = new Stopwatch();
            HtmlWeb webPage = new HtmlWeb();

            stopwatch.Start();
            var result = webPage.Load(urlInput);
            stopwatch.Stop();

            int loadTime = stopwatch.Elapsed.Milliseconds;
            return stopwatch.Elapsed.Milliseconds;
        }

        /* using Stopwatch to time the loading time of the given URL
         * Returns the load time in milliseconds as a string
         * Note use of using System.Diagnostics; */

        public bool ValidateLoadTime(int loadingTime)
        {
            bool LoadTimePass;
            if (loadingTime < 700)
            {
                LoadTimePass = true;
            }
            else
            {
                LoadTimePass = false;
            }
            return LoadTimePass;
        }
    }
}
