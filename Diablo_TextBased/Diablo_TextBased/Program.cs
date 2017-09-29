using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool tempBoolAnswer = false;
            do
            {
                int tempCounter = 0;
                Console.WriteLine("Welcome to Diablo 1");
                tempCounter = tempCounter + 1;
                Console.WriteLine(tempCounter + ". Start New Game");
                tempCounter = tempCounter + 1;
                Console.WriteLine(tempCounter + ". Save Game (Coming Soon)");
                tempCounter = tempCounter + 1;
                Console.WriteLine(tempCounter + ". Load Game (Coming Soon)");
                tempCounter = tempCounter + 1;
                Console.WriteLine(tempCounter + ". Controls");
                tempCounter = tempCounter + 1;
                Console.WriteLine(tempCounter + ". Quit");

                string tempAnswer = Console.ReadLine();
                int tempIntAnswer = Convert.ToInt32(tempAnswer);
                if (tempIntAnswer == 1)
                {
                    Console.Clear();
                    Player Player = new Player();
                    Game(Player);
                    tempBoolAnswer = true;
                }
                else if (tempIntAnswer == 2)
                {
                    //Save Game
                }
                else if (tempIntAnswer == 3)
                {
                    //Load Game
                }
                else if (tempIntAnswer == 4)
                {
                    //Controls
                    Controls();
                    continue;
                }
                else if (tempIntAnswer == 5)
                {
                    //Quit
                    return;
                }
                else
                {
                    //Repeat Loop
                    Console.Clear();
                    continue;
                }
            } while (!tempBoolAnswer);
            Console.ReadLine();
        }
        /// <summary>
        /// Summarizes the control buttons and the point of the game.
        /// </summary>
        public static void Controls()
        {
            Console.Clear();
            Console.WriteLine("Control Buttons:");
            Console.WriteLine("Equipment: E");
            Console.WriteLine("Inventory: I");
            Console.WriteLine("Stats: T");
            Console.WriteLine("Show Control Buttons In-Game: B");
            Console.WriteLine("Exit Game: Q (With A Warning)\n");

            Console.WriteLine("Instructions: ");
            Console.WriteLine("Explore the dungeons in all kind of possibilites and take on the");
            Console.WriteLine("enemies standing in your way!");
            Console.WriteLine("Grab new equipment and take on stronger enemies, on an adventure");
            Console.WriteLine("to take on the bad people and become a hero!\n");

            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Game(Player player)
        {
            Console.WriteLine("You wake up in an unkown place.. You see a cave nearby and crawl into it...");
            System.Threading.Thread.Sleep(1000);

            Room.CreateRoom(1, 1, 1);
            Warrior.CreateWarrior(10);

            player.Attack();


            
        }
    }
}
