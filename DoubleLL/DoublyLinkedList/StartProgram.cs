using DoublyLinkedList.Model;
using System;

namespace DoublyLinkedList
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            Test2();
        }

        private static void Test2()
        {
            CircularLinkedList<int> circlerList = new CircularLinkedList<int>();

            circlerList.Add(1);
            circlerList.Add(2);
            circlerList.Add(3);
            circlerList.Add(4);
            circlerList.Add(5);


            foreach (var item in circlerList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            circlerList.Delete(1);
            circlerList.Delete(2);
            circlerList.Delete(3);

            foreach (var item in circlerList)
            {
                Console.WriteLine(item);
            }
        }

        private static void Test1()
        {
            DuplexLinkedList<int> duplex = new DuplexLinkedList<int>();

            duplex.Add(10);
            duplex.Add(20);
            duplex.Add(30);
            duplex.Add(40);

            foreach (var item in duplex)
            {
                Console.WriteLine(item + " ");
            }

            duplex.Deelte(20);

            Console.WriteLine();

            foreach (var item in duplex)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();

            var revers = duplex.Revers();

            foreach (var item in revers)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();
        }
    }
}
