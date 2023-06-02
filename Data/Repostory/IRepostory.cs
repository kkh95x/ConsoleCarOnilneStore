using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repostory
{
    public interface IRepostory<T>
    {
        public List<T> getAll();
        public void save(T newRow);
        public T? get(int id);
        public void update(T row);
        public void delete(T row);
       
    }
}
