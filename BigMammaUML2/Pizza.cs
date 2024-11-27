using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML2
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Toppings { get; set; }

        public Pizza(){ }
        public Pizza(int id, string name, double price, string toppings)
        {
            Id = id;
            Name = name;
            Price = price;
            Toppings = toppings;
        }

        public override string ToString()
        {
            //return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Toppings)}={Toppings}}}";
            return $"Pizza #{Id.ToString()} {Name}({Toppings}) af {Price.ToString()}Kr. ";
        }
    }
}
