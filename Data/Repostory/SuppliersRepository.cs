using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repostory
{
    public class SuppliersRepository : Repostory<Supplier>
    {
        public SuppliersRepository(MyDbContext myDb) : base(myDb)
        {

        }
       
        public override void delete(Supplier row)
        {

            myDb.Suppliers.Remove(row);
            myDb.SaveChanges();
        }

        public override Supplier? get(int id)
        {

            return myDb.Suppliers.Find(id);
        }

        public override List<Supplier> getAll()
        {

            return myDb.Suppliers.ToList(); 
        }

        public override void save(Supplier newRow)
        {

            myDb.Suppliers.Add(newRow);
            myDb.SaveChanges();
        }

        public override void update(Supplier row)
        {

            myDb.Suppliers.Update(row);
            myDb.SaveChanges();
        }
    }
}
