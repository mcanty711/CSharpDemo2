using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining queue of integers
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            //printing the element at the front of the queue
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("Top value in the queue is: {0}", queue.Peek());
            queue.Enqueue(3);

            Console.WriteLine("Top value in the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                //Dequeue will return the element that was removed from the queue
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                Console.WriteLine("Current queue is: {0}", queue.Count);
            }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }
            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }
            //as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                //remove the order at the front of the queue and store it in a variable 
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }
            
            //this method will create an array of orders and return it
            static Order[] ReceiveOrdersFromBranch1()
            {
                //creating new orders array
                Order[] orders = new Order[]
                {
                new Order(1,5),
                new Order(2,4),
                new Order(6, 10)
                };
                return orders;
            }

            static Order[] ReceiveOrdersFromBranch2()
            {
                //creating new orders array and initializing it with some objects of type order
                Order[] orders = new Order[]
                {
                new Order(3,5),
                new Order(4,4),
                new Order(5, 10)
                };
                return orders;
            }
        }
    }

    class Order
    {
        //order ID
        public int OrderId { get; set; }
        //quantity of the order
        public int OrderQuantity { get; set; }
        //constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }
        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed.");
        }
    }
}
