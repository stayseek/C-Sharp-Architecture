using System;
using System.Collections.Generic;

namespace HW1_2
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static string DummyFunc()
        {
            return GetFormatedString("Петя", "школьный друг", 30);
        }

        private static string DummyFuncAgain()
        {
            return GetFormatedString("Вася", "сосед", 54);
        }

        private static string DummyFuncMore()
        {
            return GetFormatedString("Николай", "сын", 4);
        }

        private static string GetFormatedString (string name, string description, int age)
        {
            return string.Format(Format, name, description, Address, age);
        }

        private static List<Func<string>> GetFuncSteps()
        {
            return new List<Func<string>>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }
        private static void WriteToConsole(Func <string> func)
        {
            string methodName = func.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            Console.WriteLine(func());
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }

        static void Main(string[] args)
        {
            List<Func<string>> funcs = GetFuncSteps();
            foreach (var func in funcs)
            {
                WriteToConsole(func);
            }
            Console.ReadLine();
        }
    }
}
