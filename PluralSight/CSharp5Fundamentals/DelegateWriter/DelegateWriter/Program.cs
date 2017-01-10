using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Writer writer = new Writer(logger.WriteMessage);
            
            writer("Success");
        }
    }

    public delegate void Writer(string message);

    public class Logger
    {
        public void WriteMessage(String message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
            
        }
    }
}
