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
    public class CustomerRepostory : IRepostory<Customer>
    {
       
        public void delete(Customer row)
        {
            using var myDb = new MyDbContext();

            myDb.Customers.Remove(row);
            myDb.SaveChanges();
           
        }

        public Customer? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Customers.Find(id)  ;
        }

        public List<Customer> getAll()
        {
            using var myDb = new MyDbContext();

            return myDb.Customers.ToList();
        }

        public void save(Customer newRow)
        {
            using var myDb = new MyDbContext();

            myDb.Customers.Add(newRow);
            myDb.SaveChanges();
        }

        public void update(Customer row)
        {
            using var myDb = new MyDbContext();

            myDb.Customers.Update(row);
            myDb.SaveChanges();

        }
    }
}
