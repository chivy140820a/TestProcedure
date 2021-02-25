using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal LastPrice { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
