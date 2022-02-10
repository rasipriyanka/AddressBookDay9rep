using System;

namespace AddresBookSystem
{
    internal class Program
    {
        static void Main(string[] args) 
        {
           
            Console.WriteLine("Enter a Number to Add :");
            
            AddressBook.AddPerson();
            int i = 1,n=0;
            while (i <= n)
            {
                try
                {
                    //avoid dublicate persons
                    AddressBook.DublicatePerson();
                    i++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            AddressBook.ListPeople();
        }
    }
}

   

