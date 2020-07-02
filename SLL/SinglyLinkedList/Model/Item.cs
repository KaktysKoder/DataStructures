using System;

namespace SinglyLinkedList.Model
{
    internal sealed class Item<T>
    {
        private T _data = default(T);

        public Item(T data)
        {
            Data = data;
        }

        public T Data
        {
            get { return _data; }
            set
            {
                //_data = value ?? default(T);

                //if (value != null)
                //    _data = value;

                _data = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public Item<T> Next { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
