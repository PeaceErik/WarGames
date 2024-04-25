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
        public void InfantryAttack()
        {
            // Infantry attack damages for 1/4 of remaining units
            int damage = Units / 4;
            Console.WriteLine($"Enemy1 attacks with infantry, dealing {damage} damage.");
            TakeDamage(damage);
        }

        public void MissileStrike()
        {
            // Missile strike damages for half of remaining units
            int damage = Units / 2;
            Console.WriteLine($"Enemy1 launches a missile strike, dealing {damage} damage.");
            TakeDamage(damage);
        }

        public void TankBlitz()
        {
            // Tank blitz damages for 3/4 of remaining units
            int damage = (Units * 3) / 4;
            Console.WriteLine($"Enemy1 executes a tank blitz, dealing {damage} damage.");
            TakeDamage(damage);
        }

        // Method to choose a random attack
        public void ChooseRandomAttack()
        {
            int attackIndex = random.Next(4); // Generate a random number between 0 and 3
            switch (attackIndex)
            {
                case 0:
                    InfantryAttack();
                    break;
                case 1:
                    MissileStrike();
                    break;
                case 2:
                    TankBlitz();
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

