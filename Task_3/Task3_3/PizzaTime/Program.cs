using System;
using System.Collections.Generic;


namespace PizzaTime
{
    class Program
    {
        public static void Main(string[] args)
        {
            WorkingConsole show = new WorkingConsole();

            show.StartShow();
        }
    }

    public class WorkingConsole
    {
        Pizzaria pizzaria;
        public WorkingConsole()
        {
            pizzaria = new Pizzaria();

            pizzaria.OnOrderInProgress += OnOrderIsInProgress;
            pizzaria.OnOrderIsReady += OnOrderIsReady;
        }

        public void StartShow()
        {
            List<NamePizza> orderMany = new List<NamePizza>()
            {
                NamePizza.Pepperoni,
                NamePizza.Venice
            };

            pizzaria.CreateOrders("Ivan", orderMany);
            pizzaria.CreateOrders("NotIvan", NamePizza.Hawaiian);

            Console.ReadKey();
        }

        public void OnOrderIsInProgress(object sender, Orders order)
        {
            Console.WriteLine($"Номер заказа {order.Id} находится на кухне для {order.WhoOrdered}!");
        }

        public void OnOrderIsReady(object sender, Orders orders)
        {
            Console.WriteLine($"Заказ {orders.Id} для {orders.WhoOrdered} готов! Можете забирать.");
        }
    }
}
