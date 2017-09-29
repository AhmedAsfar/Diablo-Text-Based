using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class Warrior : EnemyParent
    {
        public static List<Warrior> Warriors = new List<Warrior>();

        public Warrior()
        {
            myName = "Warrior";
            myHealth = 100;
        }

        public static void CreateWarrior(int Amount)
        {
            for (int i = 0; i < Amount; i++)
            {
                Warriors.Add(new Warrior());
            }
        }

        public void Attack()
        {
            Random myRandomizer = new Random();

            /*while (Player.)
            {

            }*/

        }

        public bool IsDead()
        {
            for (int i = Warriors.Count; i > 0; i--)
            {
                if (Warriors[i - 1].myHealth <= 0)
                {
                    Warriors.Remove(Warriors[i - 1]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
