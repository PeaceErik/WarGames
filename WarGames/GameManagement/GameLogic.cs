using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WarGames.Players;

namespace WarGames.GameManagement
{
    public class Game
    {
        public void Start()
        {
            Console.WriteLine("**********************************************************************\n\n\n \r\n██╗    ██╗ █████╗ ██████╗  ██████╗  █████╗ ███╗   ███╗███████╗███████╗\r\n██║    ██║██╔══██╗██╔══██╗██╔════╝ ██╔══██╗████╗ ████║██╔════╝██╔════╝\r\n██║ █╗ ██║███████║██████╔╝██║  ███╗███████║██╔████╔██║█████╗  ███████╗\r\n██║███╗██║██╔══██║██╔══██╗██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  ╚════██║\r\n╚███╔███╔╝██║  ██║██║  ██║╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗███████║\r\n ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝\r\n                                                                      \r\n\n\n **********************************************************************");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\nPress any button to start...");

            // Waiting for the player to start the game, the wargame..
            Console.ReadKey();

            // Clear the console
            Console.Clear();

            // Starting the story with an intro
            Console.WriteLine("\nThe year is 2032\n\n" +
                "The cold war 2 has been going since the pandemic back in 2019.\n" +
                "We are at the brink of World War 3, every nation on edge,\n" +
                "Waiting for someone to make a move.\n" +
                "You are the general of the United States army.\n" +
                "The Shotcaller, the big boss, controlling you nation from the War Room.\n" +
                "\nWill it end in all out nuclear war, or will peace times come?\n" +
                "The choice is yours!\n\n\n" +
                "Press any button to start...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome to U.S.W.S - United States Weapon System..\n");
            Console.WriteLine("As an extra security measure,\nwe need to confirm that you are the general:\n\n" +
                "What is your last name General?\n\n");

            // Prompt the player to input their last name
            string lastName = Console.ReadLine();

            // Create a new Player object with the provided last name
            Player player = new Player(lastName);

            Console.Clear();

            // Greeting the new General
            Console.WriteLine("\nAccess granted\n\n" +
                $"welcome, General {lastName}!\n\n\n");

            // Giving the new General the status of the state of the army
            Console.WriteLine("Here is a status briefing of\nthe current state our army is in:\n\n\n");

            Console.WriteLine($"Country: {player.Country} | Army-size: {player.Units} Units | Economy: {player.Money} m. $");

            Console.WriteLine("\n\n Press any button when you are ready to proceed...\n\n");

            while (player.Units > 0)
            {

                if (player.Units <= 0)
                {
                    Console.WriteLine("***** GAME OVER *****\n\n" +
                        $"You've lost the war General {lastName}");
                    break;
                }
            }

        }
    }
}