using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str=Console.ReadLine();
                string pattern= @"^[A-Z][a-z]{2,}(?: [A-Z][a-z]*){0,2}$";
                if (Regex.IsMatch(str, pattern)){
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
