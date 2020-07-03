namespace SinglyLinkedList.Model
{
    internal interface Insert<T>
    {
        /// <summary>
        /// Вставить данные после искомого значения.
        /// </summary>
        void InsertAfter(T target, T data);

        /// <summary>
        /// Добавить данные в начало списка.
        /// </summary>
        void AppendHead(T data);
    }
}
