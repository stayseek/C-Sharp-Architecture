using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    public interface IDoSomeMath
    {
        float DoSum(float firstNum, float secondNum);
        float DoSub(float firstNum, float secondNum);
        float DoMul(float firstNum, float secondNum);
        float DoDiv(float firstNum, float secondNum);
    }
}
