using System;

namespace PizzaPapi.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        static void Welcome()
        {
            System.Console.WriteLine("Welcome to Pizza Papi");
            System.Console.WriteLine("Papi's Best Pizza!");
            System.Console.WriteLine();

            string[] cart1 = { "", "", "" }; // initial values
            string[] cart2 = new string[3]; // default values
            string[] cart3 = new[] { "", "", "" }; // initial values - custom datatypes or earlier C# versions

            // list
            List<string> cart4 = new List<string> { "", "", "" }; // initial values
            List<string> cart5 = new List<string>(); // default values
            List<Pizza> cart6 = new List<Pizza>();

            var starter = new Starter();
            var user = new User();
            var store = new Store();
            try
            {
                Menu(starter.CreateOrder(user, store));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        static void Menu(Order cart)
        {
            var exit = false;

            do
            {
                Starter.PrintMenu();

                int select;

                int.TryParse(Console.ReadLine(), out select);

                switch (select)
                {
                    case 1:
                        cart.CreatePizza("L", "Stuffed", new List<string> { "cheese" });
                        System.Console.WriteLine("added Cheese");
                        break;
                    case 2:
                        cart.CreatePizza("L", "Stuffed", new List<string> { "pepperoni" });
                        System.Console.WriteLine("added Pepperoni");
                        break;
                    case 3:
                        cart.CreatePizza("L", "Stuffed", new List<string> { "meat lovers" });
                        System.Console.WriteLine("added Meatlovers");
                        break;
                    case 4:
                        cart.CreatePizza("L", "Stuffed", new List<string> { "custom" });
                        System.Console.WriteLine("added Custom");
                        break;
                    case 5:
                        DisplayCart(cart);
                        break;
                    case 6:
                        var fmw = new FileManager();
                        fmw.Write(cart);
                        System.Console.WriteLine("thank you, goodbye!");
                        exit = true;
                        break;
                    case 7:
                        var fmr = new FileManager();
                        DisplayCart(fmr.Read());
                        break;
                }

                System.Console.WriteLine();
            } while (!exit);
        }

        static void DisplayCart(Order cart)
        {
            foreach (var pizza in cart.Pizzas)
            {
                System.Console.WriteLine(pizza);
            }
        }
    }
}
