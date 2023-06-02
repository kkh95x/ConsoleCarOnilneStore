using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repostory
{
    public class CarsRepostory : IRepostory<Car>
    {
       
        public void delete(Car row)
        {
            using var myDb = new MyDbContext();
            myDb.Cars.Remove(row);
            myDb.SaveChanges();

        }

        public Car? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Cars.Find(id);
        }

        public List<Car> getAll()
        {
            using var myDb = new MyDbContext();

            return myDb.Cars.Include((car)=>car.Parts).ToList();
        }

        public void save(Car newRow)
        {
            using var myDb = new MyDbContext();

            myDb.Cars.Add(newRow);
            myDb.SaveChanges();
        }

        public void update(Car row)
        {
            using var myDb = new MyDbContext();

            myDb.Update(row);
            myDb.SaveChanges();
        }

      
    }
}
