using Stack.Model;
using System;

namespace Stack
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            Test1();
        }
        private static void Test1()
        {
            //var stack = new StackList<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //var item1 = stack.Pop();
            //var item2 = stack.Peek();

            //Console.WriteLine(item1);
            //Console.WriteLine(item2);

            //

            //var linkedStack = new LinkedStack<int>();

            //linkedStack.Push(10);
            //linkedStack.Push(20);
            //linkedStack.Push(30);
            //linkedStack.Push(40);
            //linkedStack.Push(50);

            //Console.WriteLine(linkedStack.Peek());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Peek());

            ArrayStack<int> array = new ArrayStack<int>(5);

            array.Push(100);
            array.Push(200);
            array.Push(300);
            array.Push(400);
            array.Push(500);

            //Ex
            //array.Push(500);

            Console.WriteLine(array.Peek());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            Console.WriteLine(array.Pop());
            //Ex
            //Console.WriteLine(array.Pop());
        }

        private static void FunctionalityCheck()
        {

        }
    }
}
