
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace UnitTesting
{
    public class Library<T> : IEnumerable<T>
    {
        private int count = 0;
        private T[] books = new T[5];
        public int Count => count;
        public void Add(T book)
        {
            if (count >= books.Length)
            {
                Array.Resize(ref books, books.Length * 2);
            }
            books[count] = book;
            count++;
        }

        public bool RemoveBook(int indexToRemove)
        {
            if (indexToRemove < 0)
                return false;

            for (int i = indexToRemove; i < count; i++)
            {
                books[i] = books[i + 1];
            }
            books[count] = default;
            count--;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}






















