using System.Collections;

namespace SinglyLinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    internal sealed class LinkedList<T> : IEnumerable, ISingleLinkedList<T>
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
            else SetHeadAndTail(data);
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

        /// <summary>
        /// Добавить данные в начало списка.
        /// </summary>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;

            Count++;
        }

        /// <summary>
        /// Вставить данные после скомого значения.
        /// </summary>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;

                while(current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        //Элемент который мы хотим вставить.
                        var item = new Item<T>(data);

                        item.Next = current.Next;
                        current.Next = item;
                        Count++;

                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                //TODO: 
                //Если список пустой, то не добавлять данные.
                //SetHeadAndTail(target);

                //Вставить данные
                //Add(data);
            }
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
