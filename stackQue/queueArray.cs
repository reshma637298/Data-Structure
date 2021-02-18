using System;
using System.Collections.Generic;

namespace stackQue
{
    public class queueArray
    {
        public int[] order;
        public int front, rear, limit;

        public void createQ(int l)                // creating a queue of user specific limit as its length
        {
            front = rear = 0;
            limit = l;
            order = new int[limit];
        }

        public void Enqueue(int num)             // enqueue the data to the rear of the queue
        {
            if (limit == rear)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                order[rear] = num;
                rear++;
                Console.WriteLine("Enqueued item: {0}", num);
            }

        }

        public void Dequeue()                           // dequeue from the front of the queue
        {
            if (front == rear)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                int Dequeue_item = order[front];
                Console.WriteLine("Dequeued the first element {0}", Dequeue_item);
                order[front] = 0;
                front++;
            }
        }

        public void Print()                               // display the queue
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.WriteLine(order[i]);
                }
            }
        }
    }
}