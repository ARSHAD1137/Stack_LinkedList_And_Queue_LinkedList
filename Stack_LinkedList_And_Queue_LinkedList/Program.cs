using System;

namespace Stack_LinkedList_And_Queue_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data structure Using Stack Linked List");
            Console.WriteLine("Hello World!");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.ReadKey();

        }
    }
}
