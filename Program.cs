﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    internal class Program
    {
        internal static float a;
        internal static float b;
        internal static float c;
        internal static double e;
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в мир калькуль. Какое действие вы хотели бы выполнить?");
            Console.WriteLine("+ сложение");
            Console.WriteLine("- минус ");
            Console.WriteLine("* уможение");
            Console.WriteLine("/ деление");
            Console.WriteLine(" sin ");
            Console.WriteLine(" cos ");
            Console.WriteLine(" tg ");
            Console.WriteLine(" ctg ");
            Console.WriteLine("r корень");
            Console.WriteLine("esc выйти");
            Console.BackgroundColor = ConsoleColor.Green;

            Console.ResetColor();
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Какое действие выполняем?");
                string f = Console.ReadLine();
                switch (f)
                {
                    case "+":
                        Summ();
                        break;
                    case "-":
                        Minus();
                        break;
                    case "*":
                        Mul();
                        break;
                    case "/":
                        Del();
                        break;
                    case "sin":
                        Sin();
                        break;
                    case "cos":
                        Cos();
                        break;
                    case "tg":
                        Tan();
                        break;
                    case "ctg":
                        Ctg();
                        break;
                    case "r":
                        Root();
                        break;
                    case "esc":
                        break;
                    default:
                        Console.WriteLine("Вам сказали, что вы можете написать. Выберете нормальное действие.");
                        break;
                }
            }
            Console.ReadKey();
        }


        static float Try()
        {
            try { float d = Convert.ToSingle(Console.ReadLine()); return d; }
            catch { Console.WriteLine("Ты читал задание? Да, поэтому вместо того чтобы давать тебе второй шанс, мы введём 0."); return 0; }
        }
        static void Summ()
        {
            Console.WriteLine("Введите первое число ");
            a = Try();
            Console.WriteLine("Введите второе число ");
            b = Try();
            c = a + b;
            Console.WriteLine(c);
        }
        static void Minus()
        {
            Console.WriteLine("Введите первое число ");
            a = Try();
            Console.WriteLine("Введите второе число ");
            b = Try();
            c = a - b;
            Console.WriteLine(c);
        }
        static void Mul()
        {
            Console.WriteLine("Введите первое число ");
            a = Try();
            Console.WriteLine("Введите второе число ");
            b = Try();
            c = a * b;
            Console.WriteLine(c);
        }
        static void Del()
        {
            Console.WriteLine("Введите первое число ");
            a = Try();
            Console.WriteLine("Введите второе число ");
            b = Try();
            c = a / b;
            Console.WriteLine(c);
        }
        static void Root()
        {
            Console.WriteLine("Введите число");
            a = Try();
            e = Math.Sqrt(a);
            Console.WriteLine(e);
        }
        static void Sin()
        {
            Console.WriteLine("Введите число");
            a = Try();
            e = Math.Sin(a);
            Console.WriteLine(e);
        }
        static void Cos()
        {
            Console.WriteLine("Введите число");
            a = Try();
            e = Math.Cos(a);
            Console.WriteLine(e);
        }
        static void Tan()
        {
            Console.WriteLine("Введите число");
            a = Try();
            e = Math.Tan(a);
            Console.WriteLine(e);
        }
        static void Ctg()
        {
            Console.WriteLine("Введите число");
            a = Try();
            e = 1 / Math.Tan(a);
            Console.WriteLine(e);
        }

    }
}
