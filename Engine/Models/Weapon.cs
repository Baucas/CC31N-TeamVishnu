using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models
{
    internal class Weapon : GameItem
    {
        public int MinimumDamage { get; }
        public int MaximumDamage { get; }

        public Weapon(int itemTypeID, string name, decimal price, string imageName, int minDamage, int maxDamage)
            : base(itemTypeID, name, price, imageName)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public override GameItem Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, ImageName, MinimumDamage, MaximumDamage);
        }
    }
}
