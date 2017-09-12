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
            while (1 == 1)
                {


                Console.WriteLine("Type the palindrome: ");
                string PalOrNah = Console.ReadLine().ToLower();


                PalOrNah = PalOrNah.Replace(" ", string.Empty);
                PalOrNah = PalOrNah.Replace(":", string.Empty);
                PalOrNah = PalOrNah.Replace(",", string.Empty);
                PalOrNah = PalOrNah.Replace(".", string.Empty);
                string reverse = "";

                for (int i = 0; i < PalOrNah.Length; i++)
                {
                    reverse = reverse + PalOrNah.Substring(PalOrNah.Length - i - 1, 1);
                }

                if (reverse == PalOrNah)
                {
                    Console.WriteLine("It's a palindrome bud.");
                }

                else
                {
                    Console.WriteLine("It's not a palidrome, bud.");
                }


                
            }
        }
    }
}
