using System;

namespace stackQue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of QUEUE using ARRAY");

            queueArray q = new queueArray();
            q.createQ(4);
            q.Enqueue(3);
            q.Enqueue(9);
            q.Enqueue(0);
            q.Enqueue(5);
            q.Print();
            q.Dequeue();
            q.Print();
            q.Dequeue();
            q.Print();

            Console.WriteLine("Implementation of STACK using ARRAY");
            stackArray s = new stackArray();
            s.stackCreate(3);
            s.push(1);
            s.push(2);
            s.push(3);
            s.display();
            s.pop();
            s.display();

            Console.WriteLine("Implementation of STACK using LINKED LIST");
            stackList sl = new stackList();
            sl.push(1);
            sl.push(2);
            sl.push(4);
            sl.display();
            sl.pop();
            sl.display();

            Console.WriteLine("Implementation of QUEUE using LINKED LIST");
            queueList ql = new queueList();
            ql.enqueue(1);
            ql.enqueue(2);
            ql.enqueue(3);
            ql.enqueue(4);
            ql.display();
            ql.dequeue();
            ql.display();
        }
    }
}
