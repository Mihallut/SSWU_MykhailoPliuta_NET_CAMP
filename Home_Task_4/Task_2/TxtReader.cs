using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class TxtReader
    {

        public static string ReadTextFromFile(string path)
        {
            string text, line;
            StreamReader sr = new StreamReader(path);

            line = sr.ReadLine();
            text = line;
            while (line != null)
            {
                line = sr.ReadLine();
                text += line;
            }
            sr.Close();

            return text;
        }
    }
}
