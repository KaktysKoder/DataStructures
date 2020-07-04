using DoublyLinkedList.Model;
using System;

namespace DoublyLinkedList
{
    internal sealed class StartProgram
    {
        private static void Main()
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
