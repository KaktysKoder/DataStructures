using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    /// <summary>
    /// Обёртка над коллекцией (List'a) в виде стека.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal sealed class StackList<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;

        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();

                items.Remove(item);

                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();

                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами.";
        }

        public object Clone()
        {
            var newStack = new StackList<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
