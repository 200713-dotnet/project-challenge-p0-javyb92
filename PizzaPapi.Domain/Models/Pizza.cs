using System.Collections.Generic;
using System.Text;

namespace PizzaPapi.Domain.Models
{
    public class Pizza
    {

        private readonly string _imageUrl = "https://some-url";
        private const double _diameter = 0;
        private static string _name = "pizza";
        private List<string> _toppings = new List<string>();

        public string Crust { get; }
        public string Size { get; }
        public List<string> Toppings
        {
            get
            {
                return _toppings;
            }
        }

        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);
        }

        public Pizza()
        {
            Size = "";
            Crust = "";
        }

        void AddToppings(string topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var t in Toppings)
            {
                sb.Append(t + ", ");
            }

            return $"{Crust} \n{Size} \n{sb}";
        }

    }
}