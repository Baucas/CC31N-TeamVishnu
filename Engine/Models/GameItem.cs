using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    internal class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }

        public GameItem(int itemTypeID, string name, decimal price, string imageName) 
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
        }

        public virtual GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }
    }
}
