/*
 
Implement the concept of Array and Objects
Create a class named student with data members id, name, mark [3], total and the member functions 
are read ( ), calculate ( ) and display ( ). The read ( ) is for read n student details .Using calculate ( ) 
find the sum of 3 marks and store in total. The display ( ) is for display n student details

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ARRAY_AND_OBJECTS
    {
        class Student
        {
            public int id, m1, m2, m3, total;
            public string name;

            public static void Main(string[] args)
            {
                int n;
                Console.WriteLine("Enter the number of students");
                n = int.Parse(Console.ReadLine());
                Student[] s = new Student[n];
                for (int i = 0; i < n; i++)
                {
                    s[i] = new Student();
                    s[i].read();
                    s[i].calculate();
                    s[i].display();
                }
            }
            public void read()
            {
                Console.WriteLine("Enter id ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter  three marks ");
                m1 = int.Parse(Console.ReadLine());
                m2 = int.Parse(Console.ReadLine());
                m3 = int.Parse(Console.ReadLine());
            }
            public void calculate()
            {
                total = m1 + m2 + m3;
            }
            public void display()
            {
                Console.WriteLine("id=" + id);
                Console.WriteLine("name=" + name);
                Console.WriteLine("mark1=" + m1);
                Console.WriteLine("mark2=" + m2);
                Console.WriteLine("mark3=" + m3);
                Console.WriteLine("total=" + total);
            }
        }

    }
}
