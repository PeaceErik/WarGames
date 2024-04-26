using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.Interfaces;

namespace WarGames.Players
{
    public class Player : IPlayers, IHealth
    {
        public string LastName { get; set; }
        public string Country { get { return "USA"; } } // The plauer is allways controlling the US army
        public int Units { get; set; } = 200000; //Default units/health from the getgo
        public int Money { get; set; } = 500; // Default money from the getgo (In millions, simplified)

        public void ShowAvailableActions()
        {
            Console.WriteLine("Available Actions:");
            Console.WriteLine("1. Use Nuke");
            Console.WriteLine("2. Order Infantry Attack");
            Console.WriteLine("3. Launch Missile Strike");
            Console.WriteLine("4. Send in Tanks");
        }

        public void PerformAction(int playerChoice, Enemy1 enemy)
        {
            Console.WriteLine("Enter the number of the action you want to perform:");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        PerformAction(PlayerChoice.UseNuke, enemy);
                        break;
                    case 2:
                        PerformAction(PlayerChoice.Infantry, enemy);
                        break;
                    case 3:
                        PerformAction(PlayerChoice.MissileStrike, enemy);
                        break;
                    case 4:
                        PerformAction(PlayerChoice.SendInTanks, enemy);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        // Constructor
        public Player(string lastName)
        {
            LastName = lastName;
        }

        
        public void TakeDamage(int damage)
        {
            Units -= damage;
        }

        public void GainUnits(int units)
        { 
            throw new NotImplementedException(); 
        }

        public enum PlayerChoice
        {
            UseNuke,
            Infantry,
            MissileStrike,
            SendInTanks
        }

        public void PerformAction(PlayerChoice choice, EnemyBase enemy)
        {
            switch (choice)
            {
                case PlayerChoice.UseNuke:
                    Console.Clear();
                    enemy.TakeDamage(enemy.Units); // Damage the enemy for all its health
                    Console.WriteLine("\n\n\n     _.-^^---....,,--       \r\n _--                  --_  \r\n<                        >)\r\n|                         | \r\n \\._                   _./  \r\n    ```--. . , ; .--'''       \r\n          | |   |             \r\n       .-=||  | |=-.   \r\n       `-=#$%&%$#=-'   \r\n          | ;  :|     \r\n _____.,-#%&$@%#&#~,._____");
                    Console.WriteLine("\n\n\n\n\nGame Over - There are NO winners in nuclear war");
         
                    break;
                case PlayerChoice.Infantry:
                    Console.Clear();
                    Console.WriteLine("You've ordered an infantry attack!\n\n\n");
                    Console.WriteLine("|\\                |\\                |\\                |\\\r\n   || .---.          || .---.          || .---.          || .---.\r\n   ||/_____\\         ||/_____\\         ||/_____\\         ||/_____\\\r\n   ||( '.' )         ||( '.' )         ||( '.' )         ||( '.' )\r\n   || \\_-_/_         || \\_-_/_         || \\_-_/_         || \\_-_/_\r\n   :-\"`'V'//-.       :-\"`'V'//-.       :-\"`'V'//-.       :-\"`'V'//-.\r\n  / ,   |// , `\\    / ,   |// , `\\    / ,   |// , `\\    / ,   |// , `\\\r\n / /|Ll //Ll|| |   / /|Ll //Ll|| |   / /|Ll //Ll|| |   / /|Ll //Ll|| |\r\n/_/||__//   || |  /_/||__//   || |  /_/||__//   || |  /_/||__//   || |\r\n\\ \\/---|[]==|| |  \\ \\/---|[]==|| |  \\ \\/---|[]==|| |  \\ \\/---|[]==|| |\r\n \\/\\__/ |   \\| |   \\/\\__/ |   \\| |   \\/\\__/ |   \\| |   \\/\\__/ |   \\| |\r\n /\\|_   | Ll_\\ |   /|/_   | Ll_\\ |   /|/_   | Ll_\\ |   /|/_   | Ll_\\ |\r\n `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|\r\n    |   |   ||/       |   |   ||/       |   |   ||/       |   |   ||/\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    L___l___J         L___l___J         L___l___J         L___l___J\r\n     |_ | _|           |_ | _|           |_ | _|           |_ | _|\r\njgs (___|___)         (___|___)         (___|___)         (___|___)");
                    int infantryDamage = enemy.Units / 4; // Damage the enemy for 1/4 of their remaining units
                    enemy.TakeDamage(infantryDamage);
                    Console.WriteLine($"\n\n\nThe enemy took {infantryDamage} damage.");
                    break;

                case PlayerChoice.MissileStrike:
                    Console.Clear();
                    Console.WriteLine("You've launched a missile strike!\n\n\n");
                    Console.WriteLine("       /|,\r\n        / /,-/\r\n       .!//_/\r\n      / / |\r\n     /_  /\r\n    /: `/\r\n   /' `/\r\n   | ,'\r\n   '       ");
                    int missileDamage = enemy.Units / 3; // Damage the enemy for 1/3 of their remaining units
                    enemy.TakeDamage(missileDamage);
                    Console.WriteLine($"\n\n\nThe enemy took {missileDamage} damage.");
                    break;

                case PlayerChoice.SendInTanks:
                    Console.Clear();
                    Console.WriteLine("You've sent in tanks!\n\n\n");
                    Console.WriteLine("     \\ O\r\n       _\\--__\r\n      /  USA \\_______\r\n    __|_______|------'\r\n.  //------------\\\\\r\n....\\____________/\r\n");
                    int tankDamage = enemy.Units / 3; // Damage the enemy for 1/3 of their remaining units
                    enemy.TakeDamage(tankDamage);
                    Console.WriteLine($"\n\n\nThe enemy took {tankDamage} damage.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
