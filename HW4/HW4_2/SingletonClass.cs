using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    public class SingletonClass
    {
        private static SingletonClass _instance;

        private static readonly Lazy<SingletonClass> lazySingleton = new Lazy<SingletonClass>(() => new SingletonClass());

        private SingletonClass() {}

        public static SingletonClass GetInstance(string keyPhrase)
        {
            return lazySingleton.Value;
        }
    }
}
