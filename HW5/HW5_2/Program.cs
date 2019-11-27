using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    //Реализовать «Заместитель» при работе с классом Math, ограничив его четырьмя функциями: +,-,*,/ .
    class Program
    {        
        static void Main(string[] args)
        {
            IDoSomeMath _proxyMath = new ProxyMath();

            string firstString = string.Empty;
            string secondString = string.Empty;
            float firstNum;
            float secondNum;

            do
            {
                Console.WriteLine("Введите первое число:");
                firstString = Console.ReadLine();
            }
            while (!float.TryParse(firstString,out firstNum));

            do
            {
                Console.WriteLine("Введите второе число:");
                secondString = Console.ReadLine();
            }
            while (!float.TryParse(secondString, out secondNum));

            Console.WriteLine($"Сумма чисел равна: {_proxyMath.DoSum(firstNum, secondNum).ToString()}");
            Console.WriteLine($"Разность чисел равна: {_proxyMath.DoSub(firstNum, secondNum).ToString()}");
            Console.WriteLine($"Произведение чисел равно: {_proxyMath.DoMul(firstNum, secondNum).ToString()}");
            Console.WriteLine($"Частное чисел равно: {_proxyMath.DoDiv(firstNum, secondNum).ToString()}");
            Console.ReadLine();
        }
    }
}
