using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some resources
            //http://www.dotnetperls.com/singleton
            //https://msdn.microsoft.com/en-us/library/ff650316.aspx
            
            ////ConfigurationManager Singleton Example
            //ConfigurationManager mySettings = ConfigurationManager.GetInstance;
            //mySettings.DisplayConfiguration();
            //ConfigurationManager mySettings2 = ConfigurationManager.GetInstance;
            //mySettings2.DisplayConfiguration();

            ////SimpleSingleton example
            //SimpleSingleton ss = SimpleSingleton.Instance;

            //SiteStructure
            //SiteStructure s = SiteStructure.Instance;
            
            //SingletonB
            //SingletonB._instance.Test();

            ////SingletonC
            //SingletonC test = SingletonC.Instance;
            //Console.WriteLine(test.A);
            //test.A++;
            //Console.WriteLine(test.A);

            ////SingletonWithPrivateConstructor - does not restrict 2 instances pointing to same object
            //SingletonWithPrivateConstructor test = SingletonWithPrivateConstructor.Instance;
            //test.A++;
            //Console.WriteLine(test.A);

            //SingletonWithPrivateConstructor test2 = SingletonWithPrivateConstructor.Instance;
            //test2.A++;
            //Console.WriteLine(test.A);

            Console.ReadKey();
        }

    }

    public sealed class SiteStructure
    {
        //The singleton design pattern is an interface. It is a popular class type for programs. 
        //It allows a class to enforce that it is only allocated once. This is one of the best implementations of singleton.

        //Look at where the new SiteStructure() is initialized. The readonly and static keywords are critical here. 
        //Readonly allows thread-safety, and that means it can be only allocated once. It has a public static getter.

        //The public Instance property is used by callers to get the singleton instance.
        
        //Sealed class allows the compiler to perform special optimizations during JIT compilation. 
        
        //The final methods are the private instance constructor and an Initialize method. 
        //Private constructors mean the class can only allocate itself.


        private static readonly SiteStructure _instance = new SiteStructure();
        public static SiteStructure Instance
        {
            get 
            {
                return _instance;
            }
        }
        SiteStructure()
        {
            //Initialize
        }
    }

    class SingletonB
    {
        public static readonly SingletonB _instance = new SingletonB();
        public void Test()
        {
            Console.WriteLine(true);
        }

        SingletonB()
        {
            //Initialize
        }
    }

    public sealed class SingletonC
    {
        public static readonly SingletonC Instance = new SingletonC(); //singleton pattern, a field
        public int A; // instance field
        private SingletonC() //this is a private contructor!!
        {
            this.A = 5;
        }
    }

}
