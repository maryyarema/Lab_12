using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var regex = new Regex("(.)\\1+");
                string str = Console.ReadLine();
                Console.WriteLine(regex.Replace(str, "$1"));
            }
        }
    }
}
