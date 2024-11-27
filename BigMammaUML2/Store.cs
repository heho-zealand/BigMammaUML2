using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML2
{
    public class Store
    {
        public CustomerRepository CustomerRepository { get; private set; } = new CustomerRepository();
        public PizzaMenuCard PizzaMenuCard { get; private set; } = new PizzaMenuCard();
        public List<Order> Orders { get; private set; } = new List<Order>();

        public void AddOrder(Order nweOrder)
        {
            Orders.Add(nweOrder);
        }

        public Order GetOrder(int id)
        {
            foreach (Order order in Orders)
                if (order.Id == id) return order;
            return null;
        }

        public List<Order> GetAllOrders()
        {
            return Orders;
        }

        public Order DeleteOrder(int id)
        {
            foreach (Order order in Orders)
            {
                if (order.Id == id)
                {
                    Orders.Remove(order);
                    return order;
                }
            }
                
            return null;
        }


        public void TestCustomerRepository()
        {
            //*************  Test af CustomerRepository ****************************************************
            Console.WriteLine("Test af CustomerRepository");
            Console.WriteLine();

            
            Customer customer1 = new Customer(1, "Peter Sommer", "Musicon 34", "12345678");
            Customer customer2 = new Customer(2, "Andreas Odbjerg", "Musicon 88", "23232323");
            Customer customer3 = new Customer(3, "Peter AG", "Musicon 47", "22445678");

            CustomerRepository.AddCustomer(customer1);
            CustomerRepository.AddCustomer(customer2);
            CustomerRepository.AddCustomer(customer3);

            Console.WriteLine("Følgende 3 kunder er tilføjet listen i CustomerRepository: ");
            foreach (Customer customer in CustomerRepository.GetCustomers())
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine();

            Console.WriteLine("Test af UpdateCustomer - Peter AG -> Peter AG Nielsen:");
            CustomerRepository.UpdateCustomer(3, new Customer(3, "Peter AG Nielsen", "Musicon 47", "22445678"));

            Console.WriteLine(CustomerRepository.GetCustomer(3));
            Console.WriteLine();


            Console.WriteLine("Test af DeleteCustomer - kunde 1 slettes og returneres:");
            Customer deletedCustomer = CustomerRepository.DeleteCustomer(1);
            Console.WriteLine(deletedCustomer);
            Console.WriteLine();


            Console.WriteLine("Test af GetCustomers() efter kunde 1 er slettet:");
            foreach (Customer customer in CustomerRepository.GetCustomers())
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine();
        }

        public void TestPizzaMenuCard()
        {
            //*************  Test af PizzaMenuCard  ************************************
            Console.WriteLine("Test  af PizzaMenuCard");
            Console.WriteLine();

            PizzaMenuCard.AddPizza(1, "MARGHERITA", 69, "Tomato & cheese");
            PizzaMenuCard.AddPizza(2, "VESUVIO", 75, "Tomato,cheese & ham");
            PizzaMenuCard.AddPizza(3, "CAPRICCIOSA", 80, "Tomato,cheese,ham & mushrooms");
            PizzaMenuCard.AddPizza(4, "CALZONE", 80, "Baked pizza with tomato,cheese,ham & mushrooms");
            PizzaMenuCard.AddPizza(5, "QUATTRO STAGIONI", 85, "Tomato,cheese,ham,mushrooms,shrimp & peppers");

            Console.WriteLine("PrintMenuCard:");
            Console.WriteLine();
            PizzaMenuCard.PrintMenuCard();
            Console.WriteLine();

            Console.WriteLine("Test af SearchPizza('mushrooms')");
            List<Pizza> list = PizzaMenuCard.SearchPizza("mushrooms");

            foreach (Pizza pizza in list) Console.WriteLine(pizza);

            Console.WriteLine();


            PizzaMenuCard.AddExtraTopping("kebab", 10);
            PizzaMenuCard.AddExtraTopping("kylling", 10);
            PizzaMenuCard.AddExtraTopping("feta", 15);

            PizzaMenuCard.GetPizza(5, out Pizza tryPizza);
            Console.WriteLine("TryGetValue: " + tryPizza);
            Console.WriteLine();

            
            Console.WriteLine("Delete Pizza no 99:  " + PizzaMenuCard.DeletePizza(99));
            Console.WriteLine();


            PizzaMenuCard.DeletePizza(5, out Pizza deletedPizza);
            Console.WriteLine("Deleted Pizza: " + deletedPizza);
            Console.WriteLine();


        }


        public void TestOrder()
        {
            //*****************  Test af Order ***************************************
            Order order1 = new Order(CustomerRepository.GetCustomer(2), true);
            order1.AddOrderItem(new OrderItem(PizzaMenuCard.GetPizza(1), null, 2));
            order1.AddOrderItem(new OrderItem(PizzaMenuCard.GetPizza(2), new List<ExtraTopping>() { PizzaMenuCard.GetToppingByName("kebab") }, 1));
            order1.AddOrderItem(new OrderItem(PizzaMenuCard.GetPizza(3), null, 2));
            AddOrder(order1);
           
            Order order2 = new Order(null, false);
            order2.AddOrderItem(new OrderItem(PizzaMenuCard.GetPizza(2), new List<ExtraTopping>() { PizzaMenuCard.GetToppingByName("kylling"), PizzaMenuCard.GetToppingByName("feta") }, 2));
            order2.AddOrderItem(new OrderItem(PizzaMenuCard.GetPizza(3), null, 1));
            AddOrder(order2);
            
            foreach(Order order in GetAllOrders())
            {
                order.PrintOrder();
                Console.WriteLine();
            }
        }
    }
}
