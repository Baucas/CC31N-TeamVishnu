using Engine.Actions;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {

            BuildWeapon(1001, "Wooden Sword", 1, 2, 3);
            BuildWeapon(1002, "Broken Iron Sword", 10, 3, 5);
            BuildWeapon(1003, "Diamond Sword", 100, 5, 10);
            BuildMiscellaneousItem(9001, "BearClaw", 1);
            BuildMiscellaneousItem(9002, "BearMeat", 2);
            BuildMiscellaneousItem(9003, "BearFur", 1);
            BuildMiscellaneousItem(9004, "SnakeMeat", 2);
            BuildMiscellaneousItem(9005, "SnakeFangs", 1);
            BuildMiscellaneousItem(9006, "SnakeSkin", 2);
            BuildMiscellaneousItem(9007, "BoarTusk", 1);
            BuildMiscellaneousItem(9008, "BoarHide", 2);
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price));
        }
        private static void BuildWeapon(int id, string name, int price,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }

    }
}
