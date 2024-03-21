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
            
        }

        internal static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem item = _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID);
            if (item != null)
            {
                return item.Clone();
            }
            else
            {
                return null;
            }
        }
    }
}
