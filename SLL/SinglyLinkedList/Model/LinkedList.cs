using System;

namespace SinglyLinkedList.Model
{
    internal sealed class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count    { get; private set; }

        public LinkedList()
        {
            Head  = null;
            Tail  = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if(Tail != null)
            {
                Item<T> item = new Item<T>(data);

                Tail.Next = item;
                Tail      = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);

            Head  = item;
            Tail  = item;
            Count = 1;
        }
    }
}
