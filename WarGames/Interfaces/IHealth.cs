using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.Interfaces
{
    internal interface IHealth
    {
        int Units { get; }

        public void TakeDamage(int damage);
        public void GainUnits(int units);
    }
}
