﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        /// <summary>
        /// Метод ввода значения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Метод функции
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static double Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        static void Value()
        {
            int number1= Input("a=");
            int number2 = Input("b=");
            Console.WriteLine($"Наибольшее число = {Func(number1,number2)}");
            Console.ReadKey();
        }
    }
}
