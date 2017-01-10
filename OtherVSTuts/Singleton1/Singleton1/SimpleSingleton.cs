using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    class SimpleSingleton
    {
        private static SimpleSingleton instance;

        private SimpleSingleton() {}

        public static SimpleSingleton Instance //need the static keyword
        {
            get 
            {
                if (instance == null)
                {
                    instance = new SimpleSingleton();
                }
                return instance;
            }
        }

    
    }
}
