using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardFaces = "0123456789TJQKA";
            string card = "T";
            int value = cardFaces.IndexOf(card);
            int[] initialDeck = new int[10];
            string[] initialDeckS = new String[10];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Player 1's card " + (i + 1) + " is: ");
                initialDeck[i] = cardFaces.IndexOf(Console.ReadLine());
                initialDeckS[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Player 2's card " + (i + 1) + " is: ");
                initialDeck[i + 5] = cardFaces.IndexOf(Console.ReadLine());
                initialDeckS[i + 5] = Console.ReadLine();
                
            }

            Array.Sort(initialDeck);
            int median = initialDeck[] / 2;
            //Initial deck is set up, time for the actual game itself

            int count = 0;  //This is used to count the amount of games it runs
            while(count < 5)
            {
                int n = 0;  //used to keep track of the cards drawn
                Console.WriteLine("Game " + (count + 1) + ":");
                Console.WriteLine("Initial Point Value: ");
                int ipv = Int32.Parse(Console.ReadLine());
                


            







            }





            String[] lines = File.ReadAllLines("data.txt");


        }
    }
}
