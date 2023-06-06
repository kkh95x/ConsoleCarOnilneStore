using Data;
using Domain;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        var suppliers = new Supplier
        {
            Id = 1,
            Name = "Test",
            Address = "Address1"
        };

        var part1 = new Part
        {
            Id = 1,
            Name = "part1",
            Price = 12.2,
            Quntity = 12,
            SupplierId = suppliers.Id,
            

        };

        var part2 = new Part
        {
                Id = 2,
            Name = "part2",
            Price = 12.2,
            Quntity = 12,
            SupplierId = suppliers.Id,


        };


        Car car = new Car{
            Gear = "Gear",
            Km = 20,
            Model="hondai",
            Parts = 
            {
               part1,
                

            }

    
    };




    }
}
