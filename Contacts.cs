using System;
using System.Collections.Generic;
class PhoneBook
{
    
    static void Main(string[] args)
    {
        string choice;
        List<string> name = new List<string>();
        List<string> phonenumber = new List<string>();
        do
        {
            Console.WriteLine("1 : AddContactDetails");
            Console.WriteLine("2 : deleteContactDetails");
            Console.WriteLine("3 : displayContactDetails");
            Console.WriteLine("4 : Exit");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    DeleteContact();
                    break;
                case 3:
                    ShowContact();
                    break;
                default:
                    break;
            }
            void AddContact()
            {
                Console.Write("How many contacts you want to add : ");
                int limit = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine("enter name : ");
                    name.Insert(i, Console.ReadLine());
                    Console.WriteLine("enter phonenumber : ");
                    phonenumber.Insert(i, Console.ReadLine());
                }
            }
            void DeleteContact()
            {
                Console.Write("How many contacts you want to delete ");
                int limit= Int32.Parse(Console.ReadLine());
                for (int j = 0; j < limit; j++)
                {
                    Console.WriteLine("enter the name : ");
                    name.Remove(Console.ReadLine());
                    Console.WriteLine("enter the phonenumber : ");
                    phonenumber.Remove(Console.ReadLine());
                }
            } 
            void ShowContact()
            {
                for (int k = 0; k < name.Count ; k++)
                {
                    Console.WriteLine("name : {0},phonenumber: {1}", name[k], phonenumber[k]);
                }
            }
            Console.Write("Enter your choice : press y for continue or press any other key for exit ");
            choice = Console.ReadLine();
        } while (choice =="Y"||choice =="y");
    }
}
    