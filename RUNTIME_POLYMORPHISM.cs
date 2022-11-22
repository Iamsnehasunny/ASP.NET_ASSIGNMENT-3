//Implement Run Time Polymorphism.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class RUNTIME_POLYMORPHISM
    {
        public class ParentClassA
        {
            public virtual void display()
            {
                Console.WriteLine("Mother");
            }
        }

        public class childclassB
        {
            public virtual void display()
            {
                Console.WriteLine("Children");
            }
        }
        class polymorphism 
        {
            static void Main(string[] args)
            {
                ParentClassA obj1 = new ParentClassA();
                childclassB obj2 = new childclassB();
                Console.WriteLine("A Family consist of");
                obj1.display();
                Console.WriteLine("Father and their");
                obj2.display();
            }
        }
    }
}
