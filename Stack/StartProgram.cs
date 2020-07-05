using Stack.Model;
using System;

namespace Stack
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            ArrayStack<int> array = new ArrayStack<int>(5);

            Console.WriteLine($"Кол-во элементов в стеке = {array.Count}");

            array.Push(100);
            array.Push(200);
            array.Push(300);
            array.Push(400);
            array.Push(500);

            Console.WriteLine($"Кол-во элементов в стеке = {array.Count}");

            Console.WriteLine(array.Peek());

            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());

            Console.WriteLine($"Кол-во элементов в стеке = {array.Count}");
        }
    }
}
