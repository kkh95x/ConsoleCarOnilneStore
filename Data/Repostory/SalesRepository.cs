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
    public class SalesRepository : Repostory<Sale>

    {
        public SalesRepository(MyDbContext myDb) : base(myDb)
        {

        }

        public override void delete(Sale row)
        {

            myDb.Sales.Remove(row); 
            myDb.SaveChanges();
        }

        public override Sale? get(int id)
        {

            return base.myDb.Sales.Find(id);
        }

        public override List<Sale> getAll()
        {
            return myDb.Sales.Include((sale)=>sale.Car).Include((sale)=>sale.Customer).ToList();    
        }

        public override void save(Sale newRow)
        {
            myDb.Sales.Add(newRow);
            myDb.SaveChanges(); 
        }

        public  override void update(Sale row)
        {

            myDb.Sales.Update(row);
            myDb.SaveChanges();
        }
    }
}
