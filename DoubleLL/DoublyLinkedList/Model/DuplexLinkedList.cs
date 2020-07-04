using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList.Model
{
    internal sealed class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexLinkedList() { }

        public DuplexLinkedList(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);

            Head  = item;
            Tail  = item;
            Count = 1;
        }

        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count          { get; set; }
        public bool IsEmpty => Count == 0;

        public void Add(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);

            if (IsEmpty)
            {
                Head  = item;
                Tail  =  item;
                Count = 1;

                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;

            Count++;
        }

        public void Deelte(T data)
        {
            DuplexItem<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;

                    Count--;

                    return;
                }

                current = current.Next;
            }
        }

        public DuplexLinkedList<T> Revers()
        {
            DuplexLinkedList<T> result = new DuplexLinkedList<T>();

            DuplexItem<T> current = Tail;

            while(current != null)
            {
                result.Add(current.Data);

                current = current.Previous;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            DuplexItem<T> current = Head;

            while (current != null)
            {
                yield return current;

                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)GetEnumerator();
    }
}
