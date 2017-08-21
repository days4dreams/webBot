using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace webBot
{
    public class Save
    {
        public void SaveFile()
        {
            /*
            string myList = String.Format("1.{0} \n2.{1} \n3.{2} \n...", oneToDo, twoToDo, threeToDo);
            File.WriteAllText(file, myList);
            */

            List<string> list = new List<string>();
            list.Add("Add extract info");
            list.Add("Add more info");

            string path = @"c:\WebBot.txt";

            // This text is added only once to the file.
            if (File.Exists(path))
            {
                // Create a file to write to.
                string createText = "WebBot Extract" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            foreach (string entry in list)
            {

                File.WriteAllText(path, entry);
            }
        }
    }
}
