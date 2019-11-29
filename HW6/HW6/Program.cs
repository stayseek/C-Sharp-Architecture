using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    //Используя шаблон «Цепочка обязанностей», реализовать следующую задачу: 
    //сотрудник компании желает получить одобрение на получение некоторой суммы денег.
    //Для получения одобрения сотрудник обращается к непосредственному руководителю.
    //Руководитель не имеет полномочий одобрить выделение такой суммы денег (может одобрить меньшую сумму)
    //и обращается к своему руководителю(директору компании). Директор компании может одобрить 
    //или отклонить запрос и отправить ответ сотруднику.

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
