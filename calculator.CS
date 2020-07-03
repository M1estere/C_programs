using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double a, b;
            char z;
            Console.WriteLine("Введите первое число ");
            a = Convert.ToDouble(Console.ReadLine()); // ввод числа

            Console.WriteLine("Введите второе число ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите действие (+, -, *, /, s (степень)) ");
            z=Convert.ToChar(Console.ReadLine());

            switch (z)
            {
                case '+':
                // можно if z == "+"
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b); // в конце - выделение объектов, их указание
                    break;

                case '-':
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;

                case '/':
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;

                case 's':
                    Console.WriteLine("{0} ** {1} = {2}", a, b, Math.Pow(a, b)); // возведение в степень
                    break;
                    
                default: Console.WriteLine("Ошибка");
                    break; 

            } 
        }
    }
}