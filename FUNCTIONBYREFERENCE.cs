using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class FUNCTIONBYREFERENCE
    {
        class StudentSwap
        {
            public int id;
            public string name;
            public int mark;
            public void read()
            {
                Console.WriteLine("Enter the Id, Name and Mark");
                id = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                mark = int.Parse(Console.ReadLine());
            }
            public void swap(StudentSwap val, StudentSwap val2)
            {
                StudentSwap temp = new StudentSwap();
                temp = val;
                val = val2;
                val2 = temp;
                Console.WriteLine("After Swapping");
                val.display();
                val2.display();
            }
            public void display()
            {
                Console.WriteLine("Id: {0}", id);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Mark: {0}", mark);
            }
        }

        class disp
        {
            static void Main(string[] args)
            {
                StudentSwap s1 = new StudentSwap();
                StudentSwap s2 = new StudentSwap();
                s1.read();
                s2.read();
                Console.WriteLine("Before Swapping");
                s1.display();
                s2.display();
                s1.swap(s1, s2);

                Console.ReadLine();
            }
        }
    }
}
