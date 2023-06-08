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
    public class CustomerRepostory : Repostory<Customer>
    {
        public CustomerRepostory(MyDbContext myDb):base(myDb)
        {
           
        }
        public override void delete(Customer row)
        {

            myDb.Customers.Remove(row);
            myDb.SaveChanges();
           
        }

        public override Customer? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Customers.Find(id)  ;
        }

        public override List<Customer> getAll()
        {

            return myDb.Customers.ToList();
        }

        public override void save(Customer newRow)
        {
            myDb.Customers.Add(newRow);
            myDb.SaveChanges();
        }

        public override void update(Customer row)
        {
            myDb.Customers.Update(row);
            myDb.SaveChanges();

        }
    }
}
