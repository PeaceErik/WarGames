using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.Interfaces;

namespace WarGames.Players
{
    public abstract class EnemyBase(string country, int startingUnits) : IHealth
    {
        public string Country { get; } = country;

        public int Units { get; set; } = startingUnits;

        public abstract void TakeDamage(int damage);
        public abstract void GainUnits(int units);
    }

    public class Enemy1 : EnemyBase
    {
        private readonly Random random = new Random();

        // Constructor
        public Enemy1() : base("Russia", 150000)
        {
        }

        // Implementation of TakeDamage method
        public override void TakeDamage(int damage)
        {
            // Adjust the enemy's units accordingly
            Units -= damage;
        }

        public override void GainUnits(int units)
        {
            // Calculate the amount of units gained (1/4 of remaining units)
            int unitsGained = Units / 4;

            // Update the enemy's units
            Units += unitsGained;

            // Display a message indicating the gain in units
            Console.WriteLine($"Enemy1 used missile shields to buy some time and draft some new units: {unitsGained}");
        }

        // Custom attack methods
        public void InfantryAttack(Player player)
        {
            // Infantry attack damages for 1/4 of remaining units
            int damage = Units / 4;
            Console.WriteLine($"Enemy1 attacks with infantry, dealing {damage} damage.\n\n");
            Console.WriteLine("|\\                |\\                |\\                |\\\r\n   || .---.          || .---.          || .---.          || .---.\r\n   ||/_____\\         ||/_____\\         ||/_____\\         ||/_____\\\r\n   ||( '.' )         ||( '.' )         ||( '.' )         ||( '.' )\r\n   || \\_-_/_         || \\_-_/_         || \\_-_/_         || \\_-_/_\r\n   :-\"`'V'//-.       :-\"`'V'//-.       :-\"`'V'//-.       :-\"`'V'//-.\r\n  / ,   |// , `\\    / ,   |// , `\\    / ,   |// , `\\    / ,   |// , `\\\r\n / /|Ll //Ll|| |   / /|Ll //Ll|| |   / /|Ll //Ll|| |   / /|Ll //Ll|| |\r\n/_/||__//   || |  /_/||__//   || |  /_/||__//   || |  /_/||__//   || |\r\n\\ \\/---|[]==|| |  \\ \\/---|[]==|| |  \\ \\/---|[]==|| |  \\ \\/---|[]==|| |\r\n \\/\\__/ |   \\| |   \\/\\__/ |   \\| |   \\/\\__/ |   \\| |   \\/\\__/ |   \\| |\r\n /\\|_   | Ll_\\ |   /|/_   | Ll_\\ |   /|/_   | Ll_\\ |   /|/_   | Ll_\\ |\r\n `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|   `--|`^\"\"\"^`||_|\r\n    |   |   ||/       |   |   ||/       |   |   ||/       |   |   ||/\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    |   |   |         |   |   |         |   |   |         |   |   |\r\n    L___l___J         L___l___J         L___l___J         L___l___J\r\n     |_ | _|           |_ | _|           |_ | _|           |_ | _|\r\njgs (___|___)         (___|___)         (___|___)         (___|___)");
            TakeDamage(damage);
        }

        public void MissileStrike(Player player)
        {
            // Missile strike damages for half of remaining units
            int damage = Units / 2;
            Console.WriteLine($"Enemy1 launches a missile strike, dealing {damage} damage.\n\n");
            Console.WriteLine("       /|,\r\n        / /,-/\r\n       .!//_/\r\n      / / |\r\n     /_  /\r\n    /: `/\r\n   /' `/\r\n   | ,'\r\n   '       ");
            TakeDamage(damage);
        }

        public void TankBlitz(Player player)
        {
            // Tank blitz damages for 3/4 of remaining units
            int damage = (Units * 3) / 4;
            Console.WriteLine($"Enemy1 executes a tank blitz, dealing {damage} damage.\n\n");
            Console.WriteLine("     \\ O\r\n       _\\--__\r\n      /  USR \\_______\r\n    __|_______|------'\r\n.  //------------\\\\\r\n....\\____________/\r\n");
            TakeDamage(damage);
        }

        // Method to choose a random attack
        public void ChooseRandomAttack(Player player)
        {
            int attackIndex = random.Next(4); // Generate a random number between 0 and 3
            switch (attackIndex)
            {
                case 0:
                    InfantryAttack(player);
                    break;
                case 1:
                    MissileStrike(player);
                    break;
                case 2:
                    TankBlitz(player);
                    break;
                case 3:
                    // Calculate the units gained (1/4 of remaining units)
                    int unitsGained = Units / 4;
                    GainUnits(unitsGained);
                    break;
                default:
                    
                    break;
            }
        }
    }
}

