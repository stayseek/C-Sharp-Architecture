using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Реализовать шаблон «Одиночка» для многопоточной программы с использованием оператора lock.

namespace HW4_1
{
    class Program
    {
        static private readonly Random random = new Random();
        private static void M1()
        {
            Thread.Sleep(random.Next(20, 50));
            SingletonClass singleton = SingletonClass.GetInstance($"M{Thread.CurrentThread.GetHashCode()}");
            Console.WriteLine($"Thread = {Thread.CurrentThread.GetHashCode()}, KeyPhrase = {singleton.KeyPhrase}, SingletonHash = {singleton.GetHashCode()}");
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[20];
            for (uint i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(M1);
                threads[i].Start();
            }
            Console.ReadLine();
        }
    }
}
