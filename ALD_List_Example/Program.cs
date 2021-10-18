using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_List_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            SingleLinkedList<int> sli = new SingleLinkedList<int>();

            sli.Add(1);
            sli.Add(2);
            sli.Add(3);
            sli.Add(4);


            sli.Print();







        }
    }
}
