using System;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Using Queue Linked List");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
        }
    }
}
