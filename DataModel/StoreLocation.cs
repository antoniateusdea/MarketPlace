using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class StoreLocation
    {
        public int StoreLocationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StaffNumber { get; set; }
        public bool IsActive { get; set; }
        public int StoreId { get; set; }
    }

}
