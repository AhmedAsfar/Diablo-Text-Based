using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class Dungeon
    {
        public string myDescription;
        public int myTypeOfEnemies;
        public int myAmountOfEnemies;

        public string GetDescription { get => myDescription; }
        public int GetTypeOfEnemies { get => myTypeOfEnemies; }
        public int GetAmountOfEnemies { get => myAmountOfEnemies; }
    }
}