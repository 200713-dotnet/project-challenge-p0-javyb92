using System;
using System.Collections.Generic;
using PizzaPapi.Domain.Models;

namespace PizzaPapi.Client
{
{
  public class Starter
    {
        public Order CreateOrder(User user, Store store)
        {
            try
            {
                var order = new Order();

                user.Orders.Add(order);
                store.Orders.Add(order);

                return order;
            }
            catch
            {
                throw new System.Exception("ERROR");
            }
            finally
            {
                GC.Collect();
            }
        }

        internal static void PrintMenu()
        {
            System.Console.WriteLine("Select 1 for Cheese Pizza");
            System.Console.WriteLine("Select 2 for Pepperoni Pizza");
            System.Console.WriteLine("Select 3 for MeatLovers Pizza");
            System.Console.WriteLine("Select 4 for Custom Pizza");
            System.Console.WriteLine("Select 5 for Show Cart");
            System.Console.WriteLine("Select 6 for Exit");
            System.Console.WriteLine();
        }
    }
}