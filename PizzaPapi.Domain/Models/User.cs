using System.Collections.Generic;

namespace PizzaPapi.Domain.Models
{
    public class User
    {
        public List<Order> Orders { get; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}