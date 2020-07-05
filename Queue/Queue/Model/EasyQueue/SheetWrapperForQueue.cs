using System.Collections.Generic;
using System.Linq;


namespace Queue.Model
{
    internal sealed class SheetWrapperForQueue<T>
    {
        private List<T> items = new List<T>();

        public SheetWrapperForQueue() { }

        public SheetWrapperForQueue(T data) => items.Add(data);

        private T Head   => items.Last();
        private T Tail   => items.First();
        public int Count => items.Count;


        public void Enqueue(T data) => items.Insert(0, data);

        public T Dnqueue()
        {
            var item = Head;

            items.Remove(item);

            return item;
        }

        public T Peek() => Head;

        public void Clear() => items.Clear();
    }
}
