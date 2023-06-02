using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repostory
{
    public class SuppliersRepository : IRepostory<Supplier>
    {

        public SuppliersRepository() { }
       
        public void delete(Supplier row)
        {
            using var myDb = new MyDbContext();

            myDb.Suppliers.Remove(row);
            myDb.SaveChanges();
        }

        public Supplier? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Suppliers.Find(id);
        }

        public List<Supplier> getAll()
        {
            using var myDb = new MyDbContext();

            return myDb.Suppliers.ToList(); 
        }

        public void save(Supplier newRow)
        {
            using var myDb = new MyDbContext();

            myDb.Suppliers.Add(newRow);
            myDb.SaveChanges();
        }

        public void update(Supplier row)
        {
            using var myDb = new MyDbContext();

            myDb.Suppliers.Update(row);
            myDb.SaveChanges();
        }
    }
}
