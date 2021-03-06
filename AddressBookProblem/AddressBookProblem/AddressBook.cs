using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class AddressBook
    {
        List<Contact> addresslist = new List<Contact>();
        public void Addcontact(Contact contact)
        {
            addresslist.Add(contact);
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
        }
        public void EditContact(string name)
        {
            foreach (var contact in addresslist)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("Choose the field you want to edit :\n 1.First name:\n 2.Last name:\n 3.Address:\n 4.City:\n 5.State:\n 6.Zip code:\n 7.Phone Number:\n 8.Email:\n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter you want to edit");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter you want to edit");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter you want to edit");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter you want to edit");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter you want to edit");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter you want to edit");
                            string zip = Console.ReadLine();
                            contact.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter you want to edit");
                            string phone = Console.ReadLine();
                            contact.PhoneNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter you want to edit");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            Console.WriteLine("enter Correct Option\n");
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addresslist)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    delete = contact;
                }
            }
            addresslist.Remove(delete);
            Console.WriteLine(name + " contact is deleted \n");
        }
        public void Display()
        {
            foreach (var contact in addresslist)
            {
                Console.WriteLine("Contact Details are..\n");
                Console.Write("Firstname: " + contact.FirstName + "\n" + "Lastname: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "Phone No.: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email + "\n");
            }
        }

    }
}