//Perform Stack Operations

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STACK_OPERATION
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);

            Console.WriteLine("The  elements in the stack after pop " );
            st.Pop();
           

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

    }
}
