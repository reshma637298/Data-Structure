using System;

namespace stackQue
{
    public class stackList
    {
        Node head = null;

        public void push(int value)          // pushing the data into the top(head) of the stack
        {
            Node temp = new Node();
            temp.data = value;
            temp.next = head;
            head = temp;
            Console.WriteLine("Pushed item: {0}", temp.data);
        }

        public void pop()
        {
            if (head == null)                           // checks if stack is empty
            {
                Console.WriteLine("Empty stack");
            }
            else
            {
                Console.WriteLine("Popped item: {0}", head.data);             // popping item from the top(head) of the stack
                head = head.next;
            }
        }

        public void display()                                       // to display stack
        {
            if (head == null)
            {
                Console.WriteLine("Empty stack");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }

}