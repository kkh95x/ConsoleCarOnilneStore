using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Price { get; set; }
        public int Quntity { get; set; }

        // foragin key  for Supplier
        public int SupplierId { get; set; }
        public Supplier supplierModel { get; set; }
        //m to  n RS
       public List<Car> Cars { get; set; }


    }
}
