using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            string firstNum = Console.ReadLine();
            int f = Convert.ToInt32(firstNum);
            Console.WriteLine("Input the 2nd number: ");
            string secondNum = Console.ReadLine();
            int s = Convert.ToInt32(secondNum);
            Console.WriteLine("Input the 3rd number: ");
            string thirdNum = Console.ReadLine();
            int t = Convert.ToInt32(thirdNum);

            if (f > s && f > t)
            {
                Console.WriteLine("The First Number is the Largest");
                Console.ReadLine();
            }
            if (s > f && s > t)
            {
                Console.WriteLine("The Second Number is the Largest");
                Console.ReadLine();
            }
            if (t > f && t > s)
            {
                Console.WriteLine("The Third Number is the Largest");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There is no largest number.");
                Console.ReadLine();
            }



        }
    }
}
