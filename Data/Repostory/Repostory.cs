using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repostory
{
    public abstract class Repostory<T>
    {
       public MyDbContext myDb;
       public Repostory(MyDbContext myDb)
        {
            this.myDb = myDb;   
        }
        public abstract List<T> getAll();
        public abstract void save(T newRow);
        public abstract T? get(int id);
        public abstract void update(T row);
        public abstract void delete(T row);
       
    }
}
