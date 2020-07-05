using System;

namespace Stack.Model
{
    internal sealed class LinkedStack<T>
    {
        public LinkedStack()
        {
            Head  = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            Head  = new Item<T>(data);
            Count = 1;
        }

        public Item<T> Head { get; set; }
        public int Count    { get; set; }

        public void Push(T data)
        {
            Item<T> item = new Item<T>(data)
            {
                Previous = Head
            };

            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (Count != 0)
            {
                Item<T> item = Head;

                Head = Head.Previous;
                Count--;

                return item.Data;
            }
            else throw new NullReferenceException("Stack is empty!");
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else throw new NullReferenceException("Stack is empty!");
        }
    }
}
