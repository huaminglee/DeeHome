using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime RecordDate { get; set; }
        public Employee Designer { get; set; }
        public string OrderStatus { get; set; }
        public Customer Customers { get; set; }
        public string Description { get; set; }
    }
}
