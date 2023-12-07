using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SysoevDA.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string str, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string strLine = "";
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains(str))
                        {
                            strLine += word + " ";
                        }
                    }
                }
                return strLine.Trim();
            }
        }
    }
}
