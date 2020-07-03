using System;
using SinglyLinkedList.Model;

namespace SinglyLinkedList
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            InterfaceForTestSLL();
        }
        
        private static void InterfaceForTestSLL()
        {
            try
            {
                var list = new LinkedList<int>();

                list.Add(10);
                list.Add(20);
                list.Add(30);
                list.Add(40);

                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }

                list.Delete(6);
                list.Delete(10);
                list.Delete(20);
                list.Delete(30);

                Console.WriteLine();

                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }
            }
            catch (ArgumentNullException exc)
            {
                Console.WriteLine($"Message:    ---> {exc.Message}   ");
                Console.WriteLine($"StackTrace: ---> {exc.StackTrace}");
                Console.WriteLine($"TargetSite: ---> {exc.TargetSite}");
            }
        }

    }
}
