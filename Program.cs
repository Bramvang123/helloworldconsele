using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworldconsele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("wat is je naam?");

            string ingevuld = Console.ReadLine();
            Console.WriteLine($"hallo {ingevuld}");

            Console.ReadLine();
        }
    }
}
