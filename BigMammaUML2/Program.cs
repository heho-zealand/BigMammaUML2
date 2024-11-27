using BigMammaUML2;

//Pizza pizza1 = new Pizza(1, "MARGHERITA", 69, "Tomato & cheese");
//Pizza pizza2 = new Pizza(2, "VESUVIO", 75, "Tomato,cheese & ham");
//Pizza pizza3 = new Pizza(3, "CAPRICCIOSA", 80, "Tomato,cheese,ham & mushrooms");
//Pizza pizza4 = new Pizza(4, "CALZONE", 80, "Baked pizza with tomato,cheese,ham & mushrooms");

//PizzaMenuCard pizzaMenuCard = new PizzaMenuCard();
//pizzaMenuCard.AddPizza(pizza1);
//pizzaMenuCard.AddPizza(pizza2);
//pizzaMenuCard.AddPizza(pizza3);
//pizzaMenuCard.AddPizza(pizza4);

//pizzaMenuCard.AddPizza(new Pizza(5, "QUATTRO STAGIONI", 85, "Tomato,cheese,ham,mushrooms,shrimp & peppers"));

//List<Pizza> list = pizzaMenuCard.SearchPizza("mushrooms");

//foreach (Pizza pizza in list) Console.WriteLine(pizza);

//Console.WriteLine();

//pizzaMenuCard.PrintMenuCard();



//Customer customer1 = new Customer(1, "Peter Sommer", "Musicon 34", "12345678");
//Customer customer2 = new Customer(2, "Andreas Odbjerg", "Musicon 88", "23232323");
//Customer customer3 = new Customer(3, "Peter AG", "Musicon 47", "22445678");

//CustomerRepository customerRepository = new CustomerRepository();

//customerRepository.AddCustomer(customer1);
//customerRepository.AddCustomer(customer2);
//customerRepository.AddCustomer(customer3);


//pizzaMenuCard.AddExtraTopping("kebab", 10);
//pizzaMenuCard.AddExtraTopping("kylling", 10);
//pizzaMenuCard.AddExtraTopping("feta", 15);


//Order order1 = new Order(customer1, true);
//order1.AddOrderItem(new OrderItem(pizza1, null, 2));
//order1.AddOrderItem(new OrderItem(pizza2, new List<ExtraTopping>() { pizzaMenuCard.GetToppingByName("kebab") }, 1));
//order1.AddOrderItem(new OrderItem(pizza3, null, 2));

//Console.WriteLine("Price order 1: " + order1.CalculatePrice());
//Console.WriteLine();

//order1.PrintOrder();
//Console.WriteLine();

//Order order2 = new Order(null, false);
//order2.AddOrderItem(new OrderItem(pizza2, new List<ExtraTopping>() { pizzaMenuCard.GetToppingByName("kylling"), pizzaMenuCard.GetToppingByName("feta") }, 2));
//order2.AddOrderItem(new OrderItem(pizza3, null, 1));

//order2.PrintOrder();


Store store = new Store();
store.TestCustomerRepository();
store.TestPizzaMenuCard();
store.TestOrder();
