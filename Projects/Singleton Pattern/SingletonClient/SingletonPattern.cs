using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClient
{
    public class SingletonPattern
    {
        private SingletonPattern() { }
        private static SingletonPattern instance;
        public static SingletonPattern GetSingleton()
        {
            if (instance == null)
                instance = new SingletonPattern();
            return instance;
        }
    }
}
