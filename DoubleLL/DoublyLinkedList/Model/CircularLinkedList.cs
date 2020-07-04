using System.Collections;

namespace DoublyLinkedList.Model
{
    internal sealed class CircularLinkedList<T> : IEnumerable
    {
        public CircularLinkedList() { }
        public CircularLinkedList(T data) => SetHeadItem(data);

        public DuplexItem<T> Head      { get; set; }
        public DuplexItem<T> Previouse { get; set; }

        public int Count { get; set; }
        public bool IsEmpty => Count == 0;

        public void Add(T data)
        {
            if (IsEmpty)
            {
                SetHeadItem(data);

                return;
            }

            DuplexItem<T> item = new DuplexItem<T>(data);

            item.Next     = Head;
            item.Previous = Head.Previous;
           

            Head.Previous.Next = item;
            Head.Previous      = item;

            Count++;
        }

        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;

                return;
            }

            var current = Head.Next;

            for(int i = Count; i > 0; i--)
            {
                if(current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                }

                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            for (int i = 0; i < Count; i++)
            {
                yield return current;

                current = current.Next;
            }
        }

        private void RemoveItem(DuplexItem<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;

            Count--;
        }

        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);

            Head.Next     = Head;
            Head.Previous = Head;

            Count = 1;
        }
    }
}
