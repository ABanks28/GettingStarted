using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "root";
            string password = "letmein";

            Console.WriteLine("Input a username: ");
            string user1 = Console.ReadLine();
            Console.WriteLine("Input a password: ");
            string pass1 = Console.ReadLine();

            if (user1 == user && pass1 == password)
            {
                Console.WriteLine("Username and password authenticated.. you may proceed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong.  Try again.");
                Console.WriteLine("Input a username: ");
                string user2 = Console.ReadLine();
                Console.WriteLine("Input a password: ");
                string pass2 = Console.ReadLine();

                if (user2 == user && pass2 == password)
                {
                    Console.WriteLine("Username and password authenticated.. you may proceed");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong.  One more try.");
                    Console.WriteLine("Input a username: ");
                    string user3 = Console.ReadLine();
                    Console.WriteLine("Input a password: ");
                    string pass3 = Console.ReadLine();

                    if (user3 == user && pass3 == password)
                    {
                        Console.WriteLine("Username and password authenticated.. you may proceed");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too many incorrect login attempts!  Try again later!");
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}
