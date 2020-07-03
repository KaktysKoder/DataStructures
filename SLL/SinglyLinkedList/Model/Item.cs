using System;

namespace SinglyLinkedList.Model
{
    internal sealed class Item<T>
    {
        private T _data = default;

        public Item(T data)
        {
            Data = data;
        }

        public T Data
        {
            get => _data;
            set => _data = value ?? throw new ArgumentNullException(nameof(value));

            //if(value != null)
            //_data = value;
            //else  throw new ArgumentNullException(nameof(value));
    }

        public Item<T> Next { get; set; }

        public override string ToString() => Data.ToString();

    }
}
