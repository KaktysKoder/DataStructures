using System;

namespace Stack.Model
{
    internal sealed class ArrayStack<T>
    {
        private readonly T[] items;
        private readonly int size = 10;
        private int current = -1;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current  = 1;
        }

        public int Count => items.Length;

        public void Push(T data)
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Переполнение стека");
            }
        }
        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                items[current] = default;
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
