using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    public class RestaurantX
    {
        public string Name { get; set; }
        private Queue<Order> orderQueue { get; } = new Queue<Order>();

        public RestaurantX(string name)
        {
            Name = name;
        }

        public void RegisterOrder(Order order)
        {
            orderQueue.Enqueue(order); //lägger till i kön
        }
    }
}
