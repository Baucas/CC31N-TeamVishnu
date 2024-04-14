using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Wooden Sword", 5, "Hope", 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Broken Iron Sword", 10, "Shattered Valor", 1, 3));
            _standardGameItems.Add(new Weapon(1003, "Diamond Sword", 200, "Fractured Brilliance", 3, 5));
            _standardGameItems.Add(new GameItem(9001, "Bear Claws", 3, "BearClaw.png"));
            _standardGameItems.Add(new GameItem(9002, "Bear meat", 2, "BearMeat.png"));
            _standardGameItems.Add(new GameItem(9003, "Thick Bear Fur", 5, "BearFur.png"));
            _standardGameItems.Add(new GameItem(9004, "Snake meat", 3, "SnakeMeat.png"));
            _standardGameItems.Add(new GameItem(9005, "Venomous fang", 2, "SnakeFangs.png"));
            _standardGameItems.Add(new GameItem(9006, "Snake skin", 5, "SnakeSkin.png"));
            _standardGameItems.Add(new GameItem(9007, "Boar tusk", 2, "BearTusk.png"));
            _standardGameItems.Add(new GameItem(9008, "Boar hide", 4, "BearHide.png"));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem item = _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID);
            if (item != null)
            {
                GameItem standardItem = item.Clone();
                return standardItem;
            }
            else
            {
                return null;
            }
        }
    }
}
