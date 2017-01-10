using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {



                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                myReader.Close();


            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Could not find the DIRECTORY, are you sure it exists?");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find the FILE, are you sure it exists?");
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Something didn't quite work correctly: {0}", e.Message);
            }

            finally
            {
                //cleanup

            }

            Console.ReadLine();
        }
    }
}
