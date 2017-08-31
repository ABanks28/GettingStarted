using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite food?: ");
            String input = Console.ReadLine();
            if (input == "pizza" || input == "Pizza")
            {
                Console.WriteLine("Hey, that's pretty good!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong!  That is a terrible choice and you should feel bad about yourself.   Your favorite should be pizza!");
                Console.ReadLine();
            }
        }
    }
}
