using System.Collections.Generic;

namespace Restaurant.Domain
{
    class RestaurantX
    {
        public string Name { get; set; }
        public Queue<Order> orderQueue { get; } = new Queue<Order>();

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
