using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizzaria
    {
        public event Action<object, Orders> OnOrderInProgress;
        public event Action<object, Orders> OnOrderIsReady;

        public List<Orders> orders;

        public Dictionary<NamePizza, Pizza> PizzaName = new Dictionary<NamePizza, Pizza>
            {
                { NamePizza.Pepperoni, new Pizza("Pepperoni", 30) },
                { NamePizza.Venice, new Pizza("Venice", 50) },
                { NamePizza.FourSeason, new Pizza("FourSeason", 40) },
                { NamePizza.Hawaiian, new Pizza("Hawaiian", 90) }
            };

        public Pizzaria()
        {
            orders = new List<Orders>();
        }

        public void CreateOrders(string nameWhoOrdered, NamePizza pizza)
        {
            orders.Add(
                new Orders(PizzaName[pizza], nameWhoOrdered)
                );
            TaskOrderIsInProgress(orders[orders.Count - 1]);
        }

        public void CreateOrders(string nameWhoOrdered, IEnumerable<NamePizza> pizzas)
        {
            Orders order = new Orders(EnumPizzasToObjectsPizzas(pizzas), nameWhoOrdered);

            orders.Add(order);

            TaskOrderIsInProgress(orders[orders.Count - 1]);
        }

        public void AddPizzaToOrder(NamePizza pizza, int index)
        {
            orders[index].AddPizza(PizzaName[pizza]);
        }

        public void AddPizzasToOrder(IEnumerable<NamePizza> pizzas, int index)
        {
            orders[index].AddPizzas(EnumPizzasToObjectsPizzas(pizzas));
        }

        private List<Pizza> EnumPizzasToObjectsPizzas(IEnumerable<NamePizza> pizzasNames)
        {
            List<Pizza> pizzas = new List<Pizza>();
            foreach (var pizza in pizzasNames)
            {
                // В случае, если заказали несколько пицц, то мы добавим несколько
                pizzas.Add(
                    PizzaName.Where(x => x.Key == pizza).
                    Select(x => x.Value).
                    First()
                    );
            }

            return pizzas;
        }

        public IEnumerable<Pizza> GetPizzasFromOrder(int index)
        {
            return GetOrder(index).Pizzas;
        }

        public Orders GetOrder(int index)
        {
            if (index - 1 < 0 || index > orders.Count)
            {
                throw new IndexOutOfRangeException("Не существует заказа с таким Id!");
            }

            return orders[index - 1];
        }

        public async Task TaskOrderIsInProgress(Orders orders)
        {
            // Симуляция принятия заказа
            Console.WriteLine($"{orders.WhoOrdered} делает заказ!");
            await Task.Delay(new Random().Next(4000, 7000));

            OnOrderInProgress?.Invoke(this, orders);
            await TaskOrderIsReady(orders);
        }

        public async Task TaskOrderIsReady(Orders orders)
        {
            // Симуляция готовки
            Console.WriteLine($"Заказ {orders.Id} для {orders.WhoOrdered} готовят!");
            await Task.Delay(new Random().Next(4000, 7000));
            OnOrderIsReady.Invoke(this, orders);
        }
    }
}
