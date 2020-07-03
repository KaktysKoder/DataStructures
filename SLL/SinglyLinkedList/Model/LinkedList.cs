﻿using System;
using System.Collections;

namespace SinglyLinkedList.Model
{
    internal sealed class LinkedList<T> : IEnumerable
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

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);

            Head  = item;
            Tail  = item;
            Count = 1;
        }

        public void Add(T data)
        {
            Item<T> item = new Item<T>(data);

            if (Tail != null)
            {
                Tail.Next = item;
                Tail      = item;
                Count++;
            }
            else SetHeadAndTail(data);
        }

        public void Delete(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current  = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current  = current.Next;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while(current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }
    }
}
