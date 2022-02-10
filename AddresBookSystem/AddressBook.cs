using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//----NameSpaces-------//
namespace AddresBookSystem
{
    //----Class------//
    class AddressBook
    {
    private string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Addresses { get; set; }

    public static Dictionary<string, AddressBook> People = new Dictionary<string, AddressBook>();
    public static Dictionary<string, AddressBook> MulPeople = new Dictionary<string, AddressBook>();
        //creating Dictionaries for to store the all address of people

        //It is used to  avoiding dublicate persons 
        public static void DublicatePerson()
    {
        foreach (var Element in MulPeople)
        {

            if (!MulPeople.ContainsKey(Element.Key))
                throw new CustomException(CustomException.ExceptionType.Duplicate_Exception, "Person Already Exists");

        }
        AddPerson();
    }
        //creating metod for a class
        public static void AddPerson() 
    {
        AddressBook person = new AddressBook(); // creating a object for to access instance method or variable
        Console.Write("Enter First Name: "); // Taking the inputs from user
        person.FirstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Console.ReadLine();
        Console.Write("Enter Address 1: ");
        person.Addresses = Console.ReadLine();
        Console.WriteLine("Enter State");
        person.State = Console.ReadLine();
        Console.WriteLine("Enter a City");
        person.City = Console.ReadLine();
        Console.WriteLine("Enter the Zip Code");
        person.ZipCode = Console.ReadLine();
        People.Add(person.FirstName, person);// adding the peoples to the Dictionaries
    }
    private static void PrintPerson(AddressBook person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Phone Number: " + person.PhoneNumber);
        Console.WriteLine("Address : " + person.Addresses);
        Console.WriteLine("State : " + person.State);
        Console.WriteLine("City : " + person.City);
        Console.WriteLine("ZipCode :" + person.ZipCode);
        Console.WriteLine("-------------------------------------------");
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