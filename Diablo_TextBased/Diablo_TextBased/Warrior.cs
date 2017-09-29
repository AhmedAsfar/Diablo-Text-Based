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

        /*public void Attack()
        {
            Random myRandomizer = new Random();

            while (!Player.IsDead())
            {
                bool tempFight = true;

                do
                {
                    myDamage = myRandomizer.Next(5, 15);
                    if (myDamage - Player. >= 0)
                    {
                        myHealth -= myDamage;
                        Console.WriteLine("You did " + myDamage + " damage.");
                    }
                    else if (myHealth - myDamage < 0)
                    {
                        myDamage = myHealth;
                        myHealth -= myDamage;
                        Console.WriteLine("You did " + myDamage + " damage.");
                        tempFight = false;
                    }
                    Console.Clear();

                } while (tempFight);
            }
        }*/

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
