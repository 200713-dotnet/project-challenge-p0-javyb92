using System.Collections.Generic;

namespace PizzaPapi.Domain.Models
{
    public class Store
    {
        public List<Order> Orders { get; }

        public Store()
        {
            Orders = new List<Order>();
        }
    }
}