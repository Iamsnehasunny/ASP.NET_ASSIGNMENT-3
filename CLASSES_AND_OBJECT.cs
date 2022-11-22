/*

using Classes and Object.Implement the following facilities using C# Define a class BOOK with the following specifications :
- Private members of the class BOOK are
- BOOK NO integer type
- BOOKTITLE 20 characters
- PRICE float (price per copy)
- TOTAL_COST() A function to calculate the total cost for N number of copies where N is passed to the function as argument. 
- Public members of the class BOOK are
    -INPUT() function to read BOOK_NO. BOOKTITLE, PRICE
    - PURCHASE () function to ask the user to input the number of copies to be purchased.
    - It invokes TOTAL_COST () and prints the total cost to be paid by the user.

*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class CLASSES_AND_OBJECT
    {
        class BOOK
        {
            public int BOOK_NO;
            public string BOOK_TITLE;
            public float PRICE;

            public float TOTAL_COST(int n)
            {
                return PRICE * n;
            }
            public void INPUT()
            {
                Console.Write("Enter Book No: ");
                BOOK_NO = int.Parse(Console.ReadLine());
                Console.Write("Enter Book Title: ");
                BOOK_TITLE = Console.ReadLine();
                Console.Write("Enter Price: ");
                PRICE = int.Parse(Console.ReadLine());
            }
            public void DISPLAY()
            {
                Console.WriteLine("Book No: {0}", BOOK_NO);
                Console.WriteLine("Book Title: {0}", BOOK_TITLE);
                Console.WriteLine("Price: {0}", PRICE);
            }
            public void PURCHASE()
            {
                Console.Write("Enter the number of copies to be purchased: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost to be paid: {0}", TOTAL_COST(n));
            }

            static void Main(string[] args)
            {
                BOOK b = new BOOK();
                b.INPUT();
                b.PURCHASE();
                b.DISPLAY();
            }

        }
    }
}
