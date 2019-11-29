using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {
        private static SignatureUser SetChainOfSignature()
        {
            SignatureUser DepartmentDirector = new DepartmentDirector(25000);
            SignatureUser MainDirector = new MainDirector(50000);

            DepartmentDirector.SetNextSignatureUser(MainDirector);

            return DepartmentDirector;
        }
        static void Main(string[] args)
        {
            SignatureUser chainOfSignature = SetChainOfSignature();
            Employee employee = new Employee("Vladimir");
            float testSumm = 0;
            string testString = string.Empty;
            do
            {
                Console.WriteLine($"What summ {employee.Name} wants?");
                testString = Console.ReadLine();
            }
            while (!float.TryParse(testString, out testSumm));
            chainOfSignature.CheckSumm(testSumm, employee);
            Console.ReadLine();
        }
    }
}
