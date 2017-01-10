using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x*x;
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(square(add(3,5)));
            Console.WriteLine(add(3,4));

            //Employee[] developers = new Employee[]
            //var developers = new Employee[]
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"},
                new Employee() {Id = 4, Name = "Sue"}
            };

            var sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Alex"}
            };

            //foreach (var person in developers)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //foreach (var person in sales)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //Console.WriteLine(MyLinq.Count(developers)); //using the static method syntax
            //Console.WriteLine(developers.Count()); //using instance method syntax, possible because this is an extension method!
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            // Named Method
            //foreach (var employee in developers.Where(NameStartsWithS))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            // Anonymous Method
            //foreach (var employee in developers.Where(
            //    delegate (Employee employee)
            //    {
            //        return employee.Name.StartsWith("S");
            //    }))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            // Lambda Expression
            //foreach (var employee in developers.Where(
            //    e => e.Name.StartsWith("S")
            //    ))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //foreach (var employee in developers.Where(e => e.Name.Length == 5)
            //                                   .OrderBy(e => e.Name))
            //{
            //    Console.WriteLine(employee.Name);
            //}

            var query = developers.Where(e => e.Name.Length <= 5)
                .OrderByDescending(e => e.Name)
                .Select(e => e);

            var query2 = from developer in developers
                    where developer.Name.Length == 5
                    orderby developer.Name descending 
                    select developer;

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

        }


        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
