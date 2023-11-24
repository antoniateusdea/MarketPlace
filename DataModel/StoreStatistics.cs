using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class StoreStatistics
    {

        public int StoreStatisticId { get; set; }
        public string Name { get; set; }
        public int NumberOfSales { get; set; }
        public int TotalRevenue { get; set; }
        public int Year { get; set; }
        public int StoreId { get; set; }
    }
}
}
