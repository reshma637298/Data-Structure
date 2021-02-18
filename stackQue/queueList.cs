using System;

namespace stackQue
{
    public class queueList
    {
        Node front = null;
        Node rear = null;

        public void enqueue(int value)         // enqueue the data to the rear of the queue
        {
            Node temp = new Node();
            temp.data = value;
            if (rear == null)
            {
                front = rear = temp;
            }
            rear.next = temp;
            rear = temp;
            Console.WriteLine("Enqueued item: {0}", rear.data);
        }

        public void dequeue()                       // dequeue from the front of the queue
        {
            if (front == null && rear == null)
            {
                Console.WriteLine("Empty queue");
            }
            Console.WriteLine("Dequeued item: {0}", front.data);
            Node temp = front;
            front = front.next;
        }

        public void display()           // display the queue
        {
            if (front == null && rear == null)
            {
                Console.WriteLine("Empty queue");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}