using System.Collections.Generic;

namespace PizzaTime
{
    public class Orders
    {
        private static int IdOrders { get; set; } = 0;

        public List<Pizza> Pizzas { get; }
        public string WhoOrdered { get; private set; }
        public int Id { get; private set; }

        public Orders(string nameWhoOrdered)
        {
            Pizzas = new List<Pizza>();

            WhoOrdered = nameWhoOrdered;

            IdOrders += 1;

            Id = IdOrders;
        }

        public Orders(Pizza pizza, string nameWhoOrdered) : this(nameWhoOrdered)
        {
            Pizzas.Add(pizza);
        }

        public Orders(IEnumerable<Pizza> pizzas, string nameWhoOrdered)
        {
            Pizzas = new List<Pizza>(pizzas);

            WhoOrdered = nameWhoOrdered;

            IdOrders += 1;

            Id = IdOrders;
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public void AddPizzas(IEnumerable<Pizza> pizzas)
        {
            Pizzas.AddRange(pizzas);
        }
    }
}
