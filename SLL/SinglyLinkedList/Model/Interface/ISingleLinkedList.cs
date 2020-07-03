namespace SinglyLinkedList.Model
{
    internal interface ISingleLinkedList<T>
    {
        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
        void Delete(T data);

        /// <summary>
        /// Добавление элемента в конец списока.
        /// </summary>
        void Add(T data);
    }
}
