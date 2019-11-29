using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Employee : IEmployee
    {
        private string _name;

        public Employee(string name)
        {
            _name = name;
        }
        public string Name
        {
            get 
            {
                return _name;
            }
        }
        public void SetHappy(bool giveMoney)
        {
            Console.WriteLine((giveMoney) ? $"{_name} is happy" : $"{_name} is sad");
        }
    }
}
