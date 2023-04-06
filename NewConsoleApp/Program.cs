using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х = ");
            string s = Console.ReadLine();
            double x = double.Parse(s);
            Console.WriteLine("Привет, Мир!");
            Console.ReadKey();

        }
    }
}
