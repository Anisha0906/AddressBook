using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
             AddressBook addressBook = new AddressBook();
            addressBook.addContacts("Anisha", "Das","Sunabeda", "Koraput", "Odisha", 763001, 01234567890, "abcd@gmail.com");
            addressBook.print();
            Console.ReadLine();
        }
    }
}