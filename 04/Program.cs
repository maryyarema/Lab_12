using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                str=Regex.Replace(str,"<a>", "<URL>");
                str = Regex.Replace(str, "</a>", "</URL>");
                str = Regex.Replace(str, "<a", "<URL");
                Console.WriteLine(str);
            }
        }
    }
}
