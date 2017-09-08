using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the palindrome: ");
            string PalOrNah = Console.ReadLine();

            PalOrNah = PalOrNah.Replace(" ", string.Empty);
            string reverse = "";

            for (int i = 0; i <= PalOrNah.Length; i++)
            {
                reverse = reverse + PalOrNah.Substring(PalOrNah.Length, PalOrNah.Length - i);
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
