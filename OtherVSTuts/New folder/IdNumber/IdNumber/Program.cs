using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdNumber
{
    class Program
    {
        static void Main(string[] args) { 
        
            DateTime dob = new DateTime(1968, 08, 14);
            Console.WriteLine(dob);
            SaIdentityNumber id = new SaIdentityNumber(dob, Gender.Male, SaCitizen.Citizen);
            Console.WriteLine(id.Id);
            Console.ReadLine();

            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine(id.GenerateDateOfBirth().ToString("yyyy/MM/dd"));
            }
            Console.ReadLine();

        }
    }


    public enum Gender
    {
        Male = 5,
        Female = 0
    }

    public enum SaCitizen
    {
        Citizen = 0,
        NonCitizen = 1
    }


}
