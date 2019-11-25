using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    public class SingletonClass
    {
        private static SingletonClass _instance;
        private string _keyPhrase;
        private static object _locker = new Object();
        private SingletonClass(string keyPhrase) 
        {
            _keyPhrase = keyPhrase;
        }

        public static SingletonClass GetInstance(string keyPhrase)
        {
            lock (_locker)
            {
                if (_instance == null)
                {
                    _instance = new SingletonClass(keyPhrase);
                }
                return _instance;
            }

            //if (_instance == null)
            //{
            //    _instance = new SingletonClass(keyPhrase);
            //}
            //return _instance;

        }

        public string KeyPhrase => _keyPhrase;
    }
}
