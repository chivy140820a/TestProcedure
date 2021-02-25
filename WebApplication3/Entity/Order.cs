using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public DateTime DateCreated { set; get; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
