using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sale
    {
        public int Id { get; set; }
        public double Total { get; set; } 
        
        //Foragin key for Car
        public int CarId { get; set; }
        public Car Car { get; set; }

        //Foragin key for customer
        public int CostimerId { get; set; }
        public Customer Customer { get; set; }
    }
}
