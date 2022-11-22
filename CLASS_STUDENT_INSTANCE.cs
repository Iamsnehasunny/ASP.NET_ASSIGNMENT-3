/*Create a class student with attribute name and roll number and a method displaydetails() 
for displaying the same.Create two instance of the class and call the method for each instance*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class CLASS_STUDENT_INSTANCE
    {
        class Student
        {
           public string Name;
           public int RollNumber;

            public void DisplayDetails()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Roll Number: " + RollNumber);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {

                Student s1 = new Student();
                Console.WriteLine("enter the Name and Roll Number of two students");
                s1.Name = Console.ReadLine();
                s1.RollNumber = int.Parse(Console.ReadLine());

                Student s2 = new Student();
                s2.Name = Console.ReadLine();
                s2.RollNumber = int.Parse(Console.ReadLine());

                s1.DisplayDetails();
                s2.DisplayDetails();
            }
        }

    }
}
