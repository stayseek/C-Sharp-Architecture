using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    public class ProxyMath : IDoSomeMath
    {
        private IDoSomeMath _realMath;
        public ProxyMath()
        {
            _realMath = new RealMath();
        }

        public float DoDiv(float firstNum, float secondNum)
        {
            return _realMath.DoDiv(firstNum,secondNum);
        }  

        public float DoMul(float firstNum, float secondNum)
        {
            return _realMath.DoMul(firstNum, secondNum);
        }

        public float DoSub(float firstNum, float secondNum)
        {
            return _realMath.DoSub(firstNum,secondNum);
        }

        public float DoSum(float firstNum, float secondNum)
        {
            return _realMath.DoSum(firstNum,secondNum);
        }
    }
}
