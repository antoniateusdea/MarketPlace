using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class StoreCustomer
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
