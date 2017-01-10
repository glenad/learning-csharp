using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{

    public sealed class SingletonWithPrivateConstructor
    {
        public static readonly SingletonWithPrivateConstructor Instance = new SingletonWithPrivateConstructor();

        public int A;
        private SingletonWithPrivateConstructor() //this is the private constructor!! 
        {
            this.A = 5;
        }
    }


}
