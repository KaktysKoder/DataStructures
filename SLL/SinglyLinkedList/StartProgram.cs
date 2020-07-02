using System;
using SinglyLinkedList.Model;

namespace SinglyLinkedList
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            try
            {
                var list = new Model.LinkedList<int>();

                list.Add(10);
                list.Add(20);
                list.Add(30);
                list.Add(40);
                list.Add(50);
                list.Add(60);
                list.Add(70);
                list.Add(80);
                list.Add(90);

  
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }
        
    }
}
