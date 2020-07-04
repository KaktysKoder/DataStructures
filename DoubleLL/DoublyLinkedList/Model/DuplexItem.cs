namespace DoublyLinkedList.Model
{
    internal sealed class DuplexItem<T>
    {
        public DuplexItem(T data) => Data = data;

        public T Data { get; set; }
        public DuplexItem<T> Previous { get; set; }
        public DuplexItem<T> Next { get; set; }

        public override string ToString() => Data.ToString();
    }
}
