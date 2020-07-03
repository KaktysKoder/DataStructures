using System.Collections;

namespace SinglyLinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    internal sealed class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Кол-во элементов списка.
        /// </summary>
        public int Count    { get; private set; }

        /// <summary>
        /// Создание пустого списка.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создание списка с начальным элементом.
        /// </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавление элемента в конец списока.
        /// </summary>
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

        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
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

        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            Head  = null;
            Tail  = null;
            Count = 0;
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data);

            item.Next = Head;
            Head = item;
        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);

            Head  = item;
            Tail  = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка.
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            Item<T> current = Head;

            while(current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        public override string ToString() => $"Linked List {Count} элементов";
    }
}
