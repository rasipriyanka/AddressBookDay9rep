using System;

namespace AddresBookSystem
{
    internal class Program
    {
        static void Main(string[] args) //Ability to add multiple person to address book
        {
            Console.WriteLine(" Add Person :");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x <= num)
            {
                AddressBook.AddPerson();
                x++;
            }
            AddressBook.ListPeople();
        }
    }
}

