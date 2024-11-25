using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_10
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"{Math.Round(Func(5)) + Math.Round(Func(12)) + Math.Round(Func(19),2)}");
            Console.ReadKey();
        }
        public static double Func(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }

    }
}
