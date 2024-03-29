﻿using System;
using System.Collections.Generic;
using System.Threading;
using Restaurant.Domain;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIstor:
            //Order[]
            //List<Order>
            //Queue<Order>  FIFO(first in first out)
            //Stack<Order>  LIFO(last in first out)

            RestaurantX restaurant = new RestaurantX("MaxDonalds");

            bool isRunning = true;

            string dish;
            string table;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("[1] Add order");
                Console.WriteLine("[2] List order");
                Console.WriteLine("[3] Exit");

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                Console.Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1: //add order
                    case ConsoleKey.NumPad1:

                        Console.SetCursorPosition(3, 1);
                        Console.WriteLine("Dish: ");
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("Table: ");

                        Console.SetCursorPosition("Dish: ".Length, 1);
                        dish = Console.ReadLine();
                        Console.SetCursorPosition("Table: ".Length, 1);
                        table = Console.ReadLine();

                        Order neworder = new Order(dish, table);

                        restaurant.RegisterOrder(neworder);

                        Console.Clear();

                        Console.WriteLine("Order registered!");
                        Thread.Sleep(2000);
                        
                        break;

                    case ConsoleKey.D2: //list order
                    case ConsoleKey.NumPad2:

                        Console.WriteLine("Table     Dish                      Registered");
                        Console.WriteLine("________________________________________________________");

                        foreach (Order order in restaurant.orderQueue)
                        {
                            Console.WriteLine($"{order.Table}     {order.Dish}                      {order.RegisteredAt}");
                        }

                        Console.WriteLine();
                        Console.WriteLine(">Press key to continue<");

                        Console.ReadKey();

                        break;

                    case ConsoleKey.D3:

                        isRunning = false;

                        break;
                }
            }
        }
    }
}
