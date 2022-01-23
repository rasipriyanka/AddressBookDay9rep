﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace AddresBookSystem
{
    internal class AddressBook
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string Zip { get; set; }
        private string City { get; set; }
        private string[] Address { get; set; }

        public static Dictionary<string, AddressBook> People = new Dictionary<string, AddressBook>();
        // creating Dictionaries for to store the all address of people

        public static void AddPerson()  //creating metod for a class
        {
            AddressBook person = new AddressBook(); // creating a object for to access instance method or variable

            Console.Write("Enter First Name: "); // Taking the inputs from user
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            person.Zip = Console.ReadLine();
            Console.ReadLine();
            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.ReadLine();
            Console.Write("Enter Address 1: ");
            string[] address = new string[2]; // creating Array for to store the address
            address[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            

            People.Add(person.FirstName, person);// adding the peoples to the Dictionaries
        }
        private static void PrintPerson(AddressBook person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Zip: " + person.Zip);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("Address : " + person.Address[0]);
            
        }
        public static void ListPeople() //This method used to show people who are present in Address book
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var Element in People.Values)
            {
                PrintPerson(Element);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}