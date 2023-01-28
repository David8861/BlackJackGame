﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class BlackJack
    {
        static void Main(string[] args)
        {
            Random hitcard1 = new Random();
            int hitcardone = hitcard1.Next(4, 12);
            Random hitcard2 = new Random();
            int hitcardtwo = hitcard2.Next(1, 8);
            Random hitcard3 = new Random();
            int hitcardthree = hitcard3.Next(1, 10);
            Random showncard2 = new Random();
            int showncardsecond = showncard2.Next(1, 10);
            Random staycard = new Random();
            int staycard1 = staycard.Next(1, 12);
            Random staycard2 = new Random();
            int staycardtwo = staycard2.Next(1, 12);
            string user_name, user_choice, user_choice2;

            Console.WriteLine("Hello! Before we start playing, what's your name?");
            user_name = Console.ReadLine();
            Console.WriteLine("The rules are simple, " + user_name + ". The goal of BlackJack is to get as close to 21 without busting.");
            Random showncard = new Random();
            int showncard1 = showncard.Next(3, 7);
            Console.WriteLine("Im holding " + showncard1 + ". My other card isn't revealed.");
            Random number = new Random();
            int num = number.Next(2, 6);
            Random number2 = new Random();
            int num2 = number2.Next(1, 9);
            Console.WriteLine("Your hand is " + num + " and " + num2 + ".");
            Console.WriteLine("Would you like to Hit or Stay?");
            user_choice = Console.ReadLine();

            if (user_choice == "Hit")
            {
                Console.WriteLine("Alright, " + user_name + ". Your next card is " + hitcardone + ".");
                Console.WriteLine("Hit or Stay?");
                user_choice2 = Console.ReadLine();

                if (user_choice2 == "Hit")
                {
                    Console.WriteLine("Your next card is " + hitcardtwo + ". And your total is " + (num + num2 + hitcardone + hitcardtwo) + ".");
                    if ((num + num2 + hitcardone + hitcardtwo) >= 21)
                    {
                        Console.WriteLine("Bust!");
                        return;
                    }
                    if (num + num2 + hitcardone + hitcardtwo <= 21)
                    {
                        Console.WriteLine("My next card is " + hitcardthree);
                        if (num + num2 + hitcardone + hitcardtwo + hitcardtwo + hitcardthree <= 21)
                        {
                            Console.WriteLine("");
                        }
                        else if (num + num2 + hitcardone + hitcardtwo + hitcardtwo + hitcardthree >= 21)
                        {
                            Console.WriteLine("Bust!");
                        }

                    }
                }
            }
            if (user_choice == "Stay")
            {
                Console.WriteLine("Other than " + showncard1 + ", my other card is " + showncardsecond + ".");
                if (num + num2 >= 21)
                {
                    Console.WriteLine("You win, " + user_name + "!");
                }
                if (showncard1 + showncardsecond <= 21)
                {
                    Console.WriteLine("My next card is " + staycard1 + ".");
                    Console.WriteLine("My next card is " + staycardtwo + ".");
                }
            }
        }
    }
}