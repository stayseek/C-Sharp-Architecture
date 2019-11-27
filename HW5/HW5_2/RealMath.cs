using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    class RealMath : IDoSomeMath
    {
        public float DoDiv(float firstNum, float secondNum)
        {
            return firstNum / secondNum;
        }

        public float DoMul(float firstNum, float secondNum)
        {
            return firstNum * secondNum;
        }

        public float DoSub(float firstNum, float secondNum)
        {
            return firstNum - secondNum;
        }

        public float DoSum(float firstNum, float secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
