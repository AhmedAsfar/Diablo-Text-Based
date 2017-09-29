using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class Player
    {
        string myName;
        public int myHealth;
        public int myDamage;
        public int myCurrentRoom = 0;

        public int GetHealth { get => myHealth; }
        public int GetDamage { get => myDamage; }

        public Player()
        {
            Console.Write("Enter a name for your new character: ");
            myName = Console.ReadLine();
            myHealth = 100;
        }

        public void Attack()
        {
            Random myRandomizer = new Random();

            while (Warrior.Warriors.Count > 0)
            {
                for (int i = Warrior.Warriors.Count; i > 0; i--)
                {
                    if (!Warrior.Warriors[i - 1].IsDead())
                    {
                        bool tempFight = true;

                        do
                        {
                            Console.WriteLine("There are " + Warrior.Warriors.Count + " enemies left."); // temp
                            Console.WriteLine("Enemy HP: " + Warrior.Warriors[i - 1].GetHealth);
                            Console.WriteLine("Your HP: " + myHealth);

                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Defend");
                            Console.WriteLine("3. Escape");

                            string tempAttackStyle = Console.ReadLine();
                            //int tempInput = int.TryParse(tempAttackStyle, out );
                            int tempInput = int.Parse(tempAttackStyle);

                            if (tempInput == 1)
                            {
                                myDamage = myRandomizer.Next(15, 25);
                                if (Warrior.Warriors[i - 1].myHealth - myDamage >= 0)
                                {
                                    Warrior.Warriors[i - 1].myHealth -= myDamage;
                                }
                                else if (Warrior.Warriors[i - 1].myHealth - myDamage < 0)
                                {
                                    myDamage = Warrior.Warriors[i - 1].myHealth;
                                    Warrior.Warriors[i - 1].myHealth -= myDamage;
                                    Warrior.Warriors.Remove(Warrior.Warriors[i - 1]);
                                    tempFight = false;
                                }
                            }
                            else if (tempInput == 2)
                            {
                                //Once Equipment Is Implemented.
                            }
                            else if (tempInput == 3)
                            {

                            }
                            Console.Clear();

                            /*Warrior.Warriors[i-1].myDamage = i; 
                            myHealth -= Warrior.Warriors[i - 1].myDamage;
                            Console.WriteLine("There are " + Warrior.Warriors.Count + " enemies left.");
                            Console.WriteLine("The enemy does " + Warrior.Warriors[i - 1].GetDamage + " damage to you.");
                            Console.WriteLine("You did " + myDamage + " damage.\n");*/

                        } while (tempFight);
                    }
                }
            }
        }

        public bool IsDead()
        {
            if (myHealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
