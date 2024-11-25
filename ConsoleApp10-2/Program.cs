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
            Input();
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        public static void Input()
        {
            Console.Write($"x={Math.Round(Func(5) + Func(12) + Func(19), 2)}");
            Console.ReadKey();
        }
        /// <summary>
        /// Метод функции
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Func(int a)
        {
            return (Math.Sqrt(a) + a) / 2;
        }
    }
}