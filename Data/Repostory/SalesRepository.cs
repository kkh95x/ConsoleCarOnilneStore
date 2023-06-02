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
    public class SalesRepository : IRepostory<Sale>

    {
        
        public void delete(Sale row)
        {
            using var myDb = new MyDbContext();

            myDb.Sales.Remove(row); 
            myDb.SaveChanges();
        }

        public Sale? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Sales.Find(id);
        }

        public List<Sale> getAll()
        {
            using var myDb = new MyDbContext();

            return myDb.Sales.Include((sale)=>sale.Car).Include((sale)=>sale.Customer).ToList();    
        }

        public void save(Sale newRow)
        {
            using var myDb = new MyDbContext();

            myDb.Sales.Add(newRow);
            myDb.SaveChanges(); 
        }

        public void update(Sale row)
        {
            using var myDb = new MyDbContext();

            myDb.Sales.Update(row);
            myDb.SaveChanges();
        }
    }
}
