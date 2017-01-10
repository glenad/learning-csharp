using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;

        private static object syncRoot = new Object();

        private ConfigurationManager()
        {

        }

        public static ConfigurationManager GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
                return instance;
            }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("Single instance object");
        }

    }
}
