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
    public class CarsRepostory : Repostory<Car>
    {
        public CarsRepostory(MyDbContext myDb) : base(myDb) { }
       
        
        public override void delete(Car row)
        {
            base.myDb.Cars.Remove(row);
            myDb.SaveChanges();

        }

        public override Car? get(int id)
        {

            return myDb.Cars.Find(id);
        }

        public override List<Car> getAll()
        {

            return myDb.Cars.Include((car)=>car.Parts).ToList();
        }

        public override void save(Car newRow)
        {

            myDb.Cars.Add(newRow);
            myDb.SaveChanges();
        }

        public override void update(Car row)
        {

            myDb.Update(row);
            myDb.SaveChanges();
        }

      
    }
}
