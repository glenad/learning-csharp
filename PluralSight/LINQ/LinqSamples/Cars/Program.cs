using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDb>());
            InsertData();
            QueryData();
            
            //CreateXml();
            //QueryXml();

            //var manufacturers = ProcessManufacturers("manufacturers.csv");

            //var query =
            //    from car in cars
            //    join manufacturer in manufacturers 
            //        on car.Manufacturer equals manufacturer.Name
            //    orderby car.Combined descending, car.Name ascending
            //    select new
            //    {
            //        manufacturer.Headquarters,
            //        car.Name,
            //        car.Combined
            //    };

            //var query2 =
            //    cars.Join(manufacturers,
            //        c => c.Manufacturer,
            //        m => m.Name,
            //        (c, m) => new
            //        {
            //            m.Headquarters,
            //            c.Name,
            //            c.Combined
            //        })
            //        .OrderByDescending(c => c.Combined)
            //        .ThenBy((c => c.Name));

            //foreach (var car in query2.Take(10))
            //{
            //    Console.WriteLine($"{car.Headquarters} {car.Name} : {car.Combined}");
            //}
        }

        private static void QueryData()
        {
            var db = new CarDb();
            db.Database.Log = Console.WriteLine;

            var query = from car in db.Cars
                orderby car.Combined descending, car.Name ascending
                select car;

            foreach (var car in query.Take(10))
            {
                Console.WriteLine($"{car.Name} : {car.Combined} ");
            }

        }

        private static void InsertData()
        {
            var cars = ProcessCars("fuel.csv");
            var db = new CarDb();

            if (!db.Cars.Any())
            {
                foreach (var car in cars)
                {
                    db.Cars.Add(car);
                }
                db.SaveChanges();
            }
        }

        private static void QueryXml()
        {
            var document = XDocument.Load("fuel.xml");
            var query =
                from element in document.Element("Cars")?.Elements("Car")
                where element.Attribute("Manufacturer")?.Value == "BMW"
                select element.Attribute("Name")?.Value;

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }

        private static void CreateXml()
        {
            var records = ProcessCars("fuel.csv");

            var document = new XDocument();
            var cars = new XElement("Cars");

            foreach (var record in records)
            {
                //var name = new XAttribute("Name", record.Name);
                //var combined = new XAttribute("Combined", record.Combined);
                var car = new XElement("Car",
                    new XAttribute("Name", record.Name),
                    new XAttribute("Combined", record.Combined),
                    new XAttribute("Manufacturer", record.Manufacturer)
                    );

                //car.Add(name);
                //car.Add(combined);
                cars.Add(car);
            }
            document.Add(cars);
            document.Save("fuel.xml");
        }


        private static List<Car> ProcessCars(string path)
        {
            //return
            //    File.ReadAllLines(path)
            //        .Skip(1)
            //        .Where(line => line.Length > 1)
            //        .Select(Car.ParseFromCsv)
            //        .ToList();

            var query =
                from line in File.ReadAllLines(path).Skip(1)
                where line.Length > 1
                select Car.ParseFromCsv(line);

            return query.ToList();

        }

        private static List<Manufacturer> ProcessManufacturers(string path)
        {
            var query =
                File.ReadAllLines(path)
                    .Where(l => l.Length > 1)
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],
                            Year = int.Parse(columns[2])
                        };
                    });

            return query.ToList();
        }
    }
}
