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
}

