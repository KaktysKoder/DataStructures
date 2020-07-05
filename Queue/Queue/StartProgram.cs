using System;
using Queue.Model;
using Queue.Model.ArrayQueue;

namespace Queue
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            TestArrayQueue();
        }

        private static void TestArrayQueue()
        {
            ArrayQueue<int> array = new ArrayQueue<int>(5);

            array.Enqueue(10);
            array.Enqueue(20);
            array.Enqueue(30);
            array.Enqueue(40);
            array.Enqueue(50);

            Console.WriteLine(array.Dnqueue());
            Console.WriteLine(array.Peek());
            Console.WriteLine(array.Dnqueue());
        }

        private static void TestLLQueue()
        {
            var easyQueue = new SheetWrapperForQueue<int>();

            easyQueue.Enqueue(10);
            easyQueue.Enqueue(20);
            easyQueue.Enqueue(30);
            easyQueue.Enqueue(40);
            easyQueue.Enqueue(50);


            Console.WriteLine(easyQueue.Dnqueue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dnqueue());
        }
    }
}
