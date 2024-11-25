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
            Value();
        }
        /// <summary>
        /// Метод ввода значений
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Метод функции
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        static void Value()
        {
            int number1 = Input("a=");
            int number2 = Input("b=");
            int number3 = Input("c=");
            Console.WriteLine($"Наибольшее число = {Func(Func(number1, number2), number3)}");
            Console.ReadLine();
        }
    }
}