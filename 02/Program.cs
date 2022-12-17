using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                string pattern1 = @"^\(?[+]?([0-9]{3})\)?[- ]?([0-9]{1})?[- ]?([0-9]{3})?[- ]?([0-9]{4})$";
                if (Regex.IsMatch(str, pattern1))
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("Not match");
                }
            }
        }
    }
}
