using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Qual o seu nome?");
            name = Console.ReadLine();
            Console.WriteLine("Seu nome é");
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
