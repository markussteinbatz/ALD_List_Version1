using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    class DoubleLinkedList<T> : IList<T>
    {

        public void PrintDoubleList()
        {

        }

        public T this[int index] { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
            
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public int Add(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }
    }
}
