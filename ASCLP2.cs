using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ASCL
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
                int p1Median = initialDeck[2];
                int p2Median = initialDeck[6];
            //Initial deck is set up, time for the actual game itself

            Console.WriteLine("Player 1 will puts in " + p1Median + " and player 2 puts in " + p2Median);
            int count = 0;  //This is used to count the amount of games it runs
            while (count < 5)
            {
                
                int[] p1cards = new int[5];
                int[] p2cards = new int[5];

                Console.WriteLine("Initial Point Value: ");
                int ipv = Int32.Parse(Console.ReadLine());

                Console.WriteLine("P1 draws card: ");
                string f = Console.ReadLine();
                












                    }

                }





                String[] lines = File.ReadAllLines("data.txt");


            }
        }
    }


