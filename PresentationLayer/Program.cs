using Domain;
using DataLayer.Repostory;
using System.Diagnostics;
using Data;

internal class Program
{
    private static void Main(string[] args)
    {
        using (MyDbContext myDb = new MyDbContext())
        {
            myDb.Database.EnsureCreated();
            var carsRepo = new CarsRepostory(myDb);

            ///
            /// add some rows to data base
            ///
            carsRepo.save(new Car()
            {
                Gear = "Gear1",
                Km = 12.222,
                Model = "2232",
                Parts = new List<Part>
            {
                new Part() {
                    Name = "part1",
                    Price=12.2,
                    Quntity=100,
                    supplierModel=new Supplier()
                    {
                           Address="test Address",
                           Name="karim"
                    }
                },
                  new Part() {
                    Name = "part2",
                    Price=14.2,
                    Quntity=1200,
                    supplierModel=new Supplier()
                    {
                           Address="test Address",
                           Name="karim"
                    }
                }
            }

            });

            //print some rows in data base
            Console.WriteLine("***********************\nCars\n***********************");
            foreach (var x in carsRepo.getAll())
            {
                Console.WriteLine($"Car Row -> id: {x.Id} , model: {x.Model}, km {x.Km} ");
                Console.WriteLine($"Parts for cars ID : {x.Id} , count {x.Parts.Count}");
                foreach (var y in x.Parts)
                {

                    Console.WriteLine($" parts Rows -> id: {y.Id} , Name: {y.Name}, price {y.Price} ,Quntaty {y.Quntity} ");

                }
                Console.WriteLine("******************************************************");

            }

        }
    }
}