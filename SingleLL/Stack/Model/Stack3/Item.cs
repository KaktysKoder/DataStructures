namespace Stack.Model
{
    internal sealed class Item<T>
    {
        public Item(T data) => Data = data;

        public T Data { get; set; }
        public Item<T> Previous { get; set; }

        public override string ToString() => Data.ToString();
    }
}
