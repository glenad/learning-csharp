using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "The Gradebook";
        }
        
        static void IncrementNumber(ref int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello world!");
            //ArraySegment();
            
            //Immutable();
            //UsingEnum();

            //PassByValueAndRef();

            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            WriteBytes(stats.AverageGrade);

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);

            Console.ReadLine();

            //GradeBook book2 = new GradeBook();
            //book2.AddGrade(75);

        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} ", b);
            }
            Console.WriteLine();
        }

        private static void ArraySegment()
        {

            float[] grades;
            grades = new float[3];


            AddGrades(grades);


            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.ReadLine();
        }

        private static void AddGrades(float[] grades)
        {

            if (grades.Length >= 3)
            {
                //grades = new float[100];
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
                //grades[3] = 0f;
            }
        }

        private static void UsingEnum()
        {
            string name1 = "Scott";
            string name2 = "scott";

            //bool areequal = name1.equals(name2, stringcomparison.currentcultureignorecase);
            bool areEqual = name1.Equals(name2);
            Console.WriteLine(areEqual);
           
        }

        private static void Immutable()
        {
            string name = " Scott ";
            name = name.Trim();

            //DateTime date = DateTime.Now;
            DateTime date = new DateTime(2016, 01, 01);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);

            Console.ReadLine();
        
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 4;

            IncrementNumber(ref x1);

            Console.WriteLine(x1);
        }
    }
}
