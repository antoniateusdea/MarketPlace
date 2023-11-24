using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } =
        new List<Customer>();
        public StoreLocation StoreLocation { get; set; }
        public StoreStatistic StoreStatistic { get; set; }
    }

