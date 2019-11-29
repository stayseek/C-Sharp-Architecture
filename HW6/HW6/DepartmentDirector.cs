using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class DepartmentDirector : SignatureUser
    {
        public DepartmentDirector(float maxSumm)
        {
            _maxSumm = maxSumm;
        }

        protected override void DeclineSignature(IEmployee employee)
        {
            Console.WriteLine("Department director decline signing");
            employee.SetHappy(false);
        }

        protected override void SetSignature(IEmployee employee)
        {
            Console.WriteLine("Department director signed document");
            employee.SetHappy(true);
        }
    }
}
