using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.Interfaces
{
    public interface IPlayers
    {
        string LastName { get; set; }
        string Country { get; }
        int Units { get; set; }
        int Money { get; set; }
    }
}
