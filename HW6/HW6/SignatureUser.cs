using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public abstract class SignatureUser
    {
        protected float _maxSumm;
        protected SignatureUser _nextSignatureUser;

        public void SetNextSignatureUser(SignatureUser signatureUser)
        {
            _nextSignatureUser = signatureUser;
        }
        public void CheckSumm (float summ, IEmployee employee)
        {
            if (summ <= _maxSumm)
            {
                SetSignature(employee);
            }
            else
            {
                if (_nextSignatureUser != null)
                {
                    _nextSignatureUser.CheckSumm(summ, employee);
                }
                else
                {
                    DeclineSignature(employee);
                }
            }
        }
        protected abstract void SetSignature(IEmployee employee);
        protected abstract void DeclineSignature(IEmployee employee);
    }
}
