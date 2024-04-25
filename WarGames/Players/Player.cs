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

        // Constructor
        public Player(string lastName)
        {
            LastName = lastName;
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void GainUnits(int units)
        { 
            throw new NotImplementedException(); 
        }
    }
}
