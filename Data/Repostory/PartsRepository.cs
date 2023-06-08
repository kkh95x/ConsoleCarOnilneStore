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
    public class PartsRepository : Repostory<Part>
    {
        public PartsRepository(MyDbContext myDb) : base(myDb)
        {

        }
        public override void delete(Part row)
        {
            using var myDb = new MyDbContext();

            myDb.Parts.Remove(row);
            myDb.SaveChanges();
        }

        public override Part? get(int id)
        {
            using var myDb = new MyDbContext();

            return myDb.Parts.Find(id);
        }

        public override List<Part> getAll()
        {
            using var myDb = new MyDbContext();

            return myDb.Parts.Include((part)=>part.Cars).ToList();
            
        }

        public override void save(Part newRow)
        {
            using var myDb = new MyDbContext();

            myDb.Parts.Add(newRow);
        
            myDb.SaveChanges();

        }

        public override void update(Part row)
        {
            using var myDb = new MyDbContext();

            myDb.Parts.Update(row);
            myDb.SaveChanges(); 
        }
    }
}
