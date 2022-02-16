using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplicationDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;
            ClientServer server = new ClientServer();
            do
            {
                Console.WriteLine("\n 1. User registration or Add new Contact \n 2. Send Message \n 3. Delete Contact \n 4. View all contacts ");
                Console.WriteLine(" Enter choice");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Register yourself");
                        int phno;
                        String name;
                        Console.Write("Enter phone number: ");
                        phno = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();

                        Client client1 = new Client();  //creating new instance of a client
                        client1.Phone_Number = phno;
                        client1.Name = name;
                        break;


                    case 2:
                        Console.WriteLine("Enter message");
                        break;

                    case 3:
                        Console.WriteLine(" ");
                            break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        break;


                }
                Console.WriteLine("\n Do you want to continue: press 'y' for yes 'n' for no.....\n");
                ch = Console.ReadKey().KeyChar;
            }
            while (ch == 'y');
        }
    }
}