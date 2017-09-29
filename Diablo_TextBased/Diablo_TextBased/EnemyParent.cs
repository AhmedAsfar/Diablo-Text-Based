using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class EnemyParent
    {
        public string myName = "";
        public int myHealth;
        public int myDamage;
        public int myCurrentRoom;

        public string GetName { get => myName; }
        public int GetHealth { get => myHealth; }
        public int GetDamage { get => myDamage; }
        public int GetCurrentRoom { get => myCurrentRoom; }
    }
}
