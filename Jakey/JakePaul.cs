﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isItEverydayBro
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {


                String jakePaulIsGod = "It's everyday bro, with the Disney Channel flow 5 mill on YouTube in 6 months, never done before Passed all the competition man, PewDiePie is next Man I'm poppin' all these checks, got a brand new Rolex And I met a Lambo too and I'm coming with the crew This is Team 10, bitch, who the hell are flippin' you? And you know I kick them out if they ain't with the crew Yeah, I'm talking about you, you beggin' for attention Talking shit on Twitter too but you still hit my phone last night It was 4:52 and I got the text to prove And all the recordings too, don't make me tell them the truth And I just dropped some new merch and it's selling like a god, church Ohio's where I'm from, we chew 'em like it's gum We shooting with a gun, the tattoo just for fun I Usain Bolt and run, catch me at game one I cannot be outdone, Jake Paul is number one It's everyday bro It's everyday bro It's everyday bro I said it is everyday bro! You know it's Nick Crompton and my collar stay poppin' Yes, I can rap and no, I am not from Compton England is my city And if it weren't for Team 10, then the US would be shitty I'll pass it to Chance 'cause you know he stay litty Two months ago you didn't know my name And now you want my fame? Bitch I'm blowin' up I'm only going up, now I'm going off, I'm never fallin' off Like Mag, who? Digi who? Who are you? All these beefs I just ran through, hit a milli in a month Where were you? Hatin' on me back in West Fake Think you need to get your shit straight Jakey brought me to the top, now we're really poppin' off Number 1 and number 4, that's why these fans all at our door It's lonely at the top so we all going Number 1 and number 4, that's why these fans all at our door It's lonely at the top so we all going We left Ohio, now the trio is all rollin' It's Team 10, bitch We back again, always first, never last We the future, we'll see you in the past It's everyday bro It's everyday bro It's everyday bro I said it is everyday bro! Hold on, hold on, hold on Can we switch the language? We 'bout to hit it Sí, lo único que quiero es dinero Trabajando en YouTube todo el día entero Viviendo en U.S.A, el sueño de cualquiera Enviando dólares a mi familia entera Tenemos una persona por encima Se llama Donald Trump y está en la cima Desde aquí te cantamos - can I get my VISA? Martinez Twins, representando España Desde la pobreza a la fama It's everyday bro It's everyday bro It's everyday bro I said it is everyday bro! Yo, it's Tessa Brooks The competition shook These guys up on me I got 'em with the hook Lemme educate ya' And I ain't talking book Panera is your home? So, stop calling my phone I'm flyin' like a drone They buying like a loan Yeah, I smell good Is that your boy's cologne? Is that your boy's cologne? Started balling' Quicken Loans Now I'm in my flippin' zone Yes, they all copy me But, that's some shitty clones Stay in all designer clothes And they ask me what I make I said is 10 with six zeros Always plug, merch link in bio And I will see you tomorrow 'cause It's everyday bro Peace";
                jakePaulIsGod = jakePaulIsGod.Trim();
                jakePaulIsGod = jakePaulIsGod.Replace(",", string.Empty);
                jakePaulIsGod = jakePaulIsGod.Replace("?", string.Empty);
                jakePaulIsGod = jakePaulIsGod.ToLower();

                String[] arr = jakePaulIsGod.Split(' ');

                Console.WriteLine("Enter any lyrics of the masterpiece 'It's everyday bro': ");
                String lyric = Console.ReadLine();

                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == lyric)
                    {
                        count++;
                    }
                }
                Console.WriteLine("The lyric '" + lyric + "' appears " + count + " times.");
                Console.WriteLine("");
            }
            
        }
    }
}
