using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster Bear =
                        new Monster("Bear", "Bear1.png", 4, 4, 5, 1, 4, 2);
                    AddLootItem(Bear, 9001, 25);
                    AddLootItem(Bear, 9002, 75);
                    AddLootItem(Bear, 9003, 100);
                    return Bear;
                case 2:
                    Monster Boar =
                        new Monster("Boar", "Boar.png", 5, 5, 5, 1, 7, 4);
                    AddLootItem(Boar, 9005, 25);
                    AddLootItem(Boar, 9005, 75);
                    AddLootItem(Boar, 9006, 100);
                    return Boar;
                case 3:
                    Monster Anaconda =
                        new Monster("Anaconda", "Anaconda.png", 10, 10, 10, 3, 10, 3);
                    AddLootItem(Anaconda, 9007, 25);
                    AddLootItem(Anaconda, 9008, 75);
                    return Anaconda;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }

}

