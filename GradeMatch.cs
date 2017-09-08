using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Grade: ");
            string grade = Console.ReadLine();
            
            if (grade == "e")
            {
                Console.WriteLine("You have chosen: Excellent");
                Console.ReadLine();
            }
            if (grade == "v")
            {
                Console.WriteLine("You have chosen: Very Good");
                Console.ReadLine();
            }
            if (grade == "g")
            {
                Console.WriteLine("You have chosen: Good");
                Console.ReadLine();
            }
            if (grade == "a")
            {
                Console.WriteLine("You have chosen: Average");
                Console.ReadLine();
            }
            if (grade == "f")
            {
                Console.WriteLine("You have chosen: Fail");
                Console.ReadLine();
            }
        }
    }
}
