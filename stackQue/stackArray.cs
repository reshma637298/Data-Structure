using System;

namespace stackQue
{
    public class stackArray
    {
        int top = -1;
        int max;
        int[] books;
        public void stackCreate(int limit)           // creating a stack of user specific limit as its length
        {
            books = new int[limit];
            max = limit;
        }

        public void push(int data)                  // pushing the data into the top of the stack
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflowed");       // if stack is filled upto the limit then overflow message is displayed
                return;
            }
            else
            {
                books[++top] = data;
                Console.WriteLine("Pushed item {0}", books[top]);    // if not, then pushing items to the top of the stack
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflowed");                 // checks if stack is empty
            }
            else
            {
                int popped_item = books[top];
                Console.WriteLine("Popped item is {0}", popped_item);    // popping item from the top of the stack
                top--;
            }
        }
        public void display()                                            // to display stack
        {
             if (top == -1)
            {
                Console.WriteLine("Stack underflowed");                 // checks if stack is empty
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(books[i]);
                }
            }
            
        }
    }
}