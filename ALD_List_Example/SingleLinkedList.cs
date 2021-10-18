using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    class SingleLinkedList<T> : IList<T> where T : IEquatable<T>
    {

        ListElement<T> _first;
        ListElement<T> _last;
        private int _count = 0;

        public int Count => _count;

        #region MyListElement class
        private class ListElement<T1>
        {
            public T1 Item { set; get; }
            public ListElement<T1> Next { set; get; }
            
            public void Delete()
            {
                Item = default(T1);
                Next = null;
            }
        }
        #endregion

        public SingleLinkedList()
        {

        }


        public void PrintSingleList()
        {

        }

        public T this[int index] { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public int Add(T item)
        {
 
            var element = new ListElement<T> { Item = item };
            if (_first == null) _first = element;
            if (_last != null) _last.Next = element;
            _last = element;
            return _count++;
        }

        public bool Remove(T item)
        {

            var curr = _first;
            ListElement<T> prev = null;
            for (; curr != null; prev = curr, curr = curr.Next)
            {
                if (curr.Item.Equals(item))
                {
                    if (prev == null) _first = _first.Next;
                    else prev.Next = curr.Next;
                    if (curr.Next == null) _last = prev;
                    curr.Delete();
                    _count--;
                    return true;
                }
            }

            return false;
        }


        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            if (_first != null)
            {
                StringBuilder builder = new StringBuilder();
                ListElement<T> current = _first;

                var curr = _first;
                for (; curr != null; curr = curr.Next)
                {
                    builder.Append(curr.Item);
                }

                return builder.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public void Print()
        {
            //Console.WriteLine(this);

            if (_first != null)
            {
                StringBuilder builder = new StringBuilder();
                ListElement<T> current = _first;

                while (current != null)
                {
                    Console.WriteLine(current.Item);
                    builder.Append(current.Item);

                    current = current.Next;
                }
            }
        }
    }
}
