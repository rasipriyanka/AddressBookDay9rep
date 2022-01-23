using System;
using System.Collections.Generic;
using System.Text;

namespace AddresBookSystem
{
    internal class AddressBook
    {
        public static void Address() //creating method 
        {
            Console.Write("Enter First Name: "); 
            Console.ReadLine();
            Console.Write("Enter Last Name: ");
            Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Console.ReadLine();
            Console.Write("Enter Zip: ");
            Console.ReadLine();
            Console.Write("Enter City: ");
            Console.ReadLine();
            Console.Write("Enter Address : ");
            // creating Array  to store the address
            string[] address = new string[2]; 
            address[0] = Console.ReadLine();
            
            foreach (string element in address)
            {
                Console.WriteLine(element);

            }
        }
    }

}

