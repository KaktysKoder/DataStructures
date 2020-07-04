using System;

namespace SinglyLinkedList.Model
{
    /// <summary>
    /// Ячейка списка.
    /// </summary>
    internal sealed class Item<T>
    {
        private T _data = default;

        public Item(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Данные хранимые в ячейке списка.
        /// </summary>
        public T Data
        {
            get => _data;
            set => _data = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Следующая ячейка списка.
        /// </summary>
        public Item<T> Next { get; set; }

        public override string ToString() => Data.ToString();
    }
}
