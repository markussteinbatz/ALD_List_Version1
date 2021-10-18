using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    interface IList<T>
    {
		int Add(T value);      // methods
		
		bool Contains(T value);
		
		bool IsReadOnly { get; }		// property
		
		T this[int index] { get; set; }    // indexer

	}
}
