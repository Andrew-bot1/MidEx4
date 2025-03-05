using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidEx4
{
    internal class Program
    {
        static IDictionary<string, int> Contacts = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Remove a Contact");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        RemoveContact();
                        break;
                    case 3:
                        SearchContact();
                        break;
                    case 4:
                        DisplayContacts();
                        break;
                    case 5:
                        exit = true;
                        return;
                }
            }
        }
        static void AddContact()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            if (Contacts.ContainsKey(name))
            {
                Console.WriteLine("Contact already exists");
                return;
            }
            else
            {
                Console.WriteLine("Enter Phone Number: ");
                int phone = Convert.ToInt32(Console.ReadLine());
                Contacts.Add(name, phone);
            }
                
        }
        static void RemoveContact()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            if (Contacts.ContainsKey(name))
            {
                Contacts.Remove(name);
            }
            else
            {
                Console.WriteLine("Contact does not exist");
            }
        }
        static void SearchContact()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            if (Contacts.ContainsKey(name))
            {
                Console.WriteLine("Phone Number: " + Contacts[name]);
            }
            else
            {
                Console.WriteLine("Contact does not exist");
            }
        }
        static void DisplayContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine("Name: " + contact.Key + " Phone Number: " + contact.Value);
            }
        }
    }
}
