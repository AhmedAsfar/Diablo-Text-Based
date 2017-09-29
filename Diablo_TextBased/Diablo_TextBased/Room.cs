using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    public class Room : Dungeon
    {
        public List<Room> myRooms = new List<Room>();
        public List<Room> GetRoom { get => myRooms; }

        public static int myRoomNumber = 0;

        public Room(int TypeOfEnemies, int AmountOfEnemies)
        {
            myDescription = "";
            myRooms.Add(this);
            myTypeOfEnemies = TypeOfEnemies;
            myAmountOfEnemies = AmountOfEnemies;
        }

        /*public static string Description(List<Room> Rooms)
        {
            Console.WriteLine();
            if (GetRoom.Equals(0))
            {
                myDescription = "hello";
            }
            return myDescription;
        }*/

        public static void CreateRoom(int Amount, int theTypeOfEnemies, int theAmountOfEnemies)
        {
            for (int i = 0; i < Amount; i++)
            {
            Room Room = new Room(theTypeOfEnemies, theAmountOfEnemies);
            }
        }

        public void Room1()
        {
            Console.WriteLine($"You see {Warrior.Warriors.Count} warriors coming towards you!");

        }


    }
}
