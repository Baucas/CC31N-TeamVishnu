using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        public static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Home",
                "This is your home",
                "pack://application:,,,/Engine;component/Images/Location/Home.png");
            newWorld.AddLocation(0, -1, "Town Hall",
                "The town hall is so common",
                "pack://application:,,,/Engine;component/Images/Location/TownHall.png");
            newWorld.AddLocation(1, -1, "Town's Gate",
                "You're friend is working here, you should greet him",
                "pack://application:,,,/Engine;component/Images/Location/TownGate.png");
            newWorld.AddLocation(2, -1, "Shop",
                "All you need is here",
                "pack://application:,,,/Engine;component/Images/Location/Shop.png");
            newWorld.AddLocation(3, -1, "Mark Anthony's House",
                "Please help me kill the anaconda that is eating all my livestock",
                "pack://application:,,,/Engine;component/Images/Location/MarkHouse.png");
            newWorld.AddLocation(4, -1, "Mark's Farm",
                "There is a rumor that the anaconda has a companion",
                "pack://application:,,,/Engine;component/Images/Location/MarkFarm.png");
            newWorld.AddLocation(2, 1, "Healing Fountain",
                "What a beautiful fountain",
                "pack://application:,,,/Engine;component/Images/Location/HealingFountain.png");
            newWorld.AddLocation(1, 1, "Acorn Garden",
                "There are many boars, you should kill them",
                "pack://application:,,,/Engine;component/Images/Location/AcornGarden.png");
            newWorld.AddLocation(3, 1, "Bear",
                "There is one bear that lost its direction",
                "pack://application:,,,/Engine;component/Images/Location/Bear.png");
            newWorld.AddLocation(4, 1, "Karlo's Honey Garden",
                "There are bears that are destroying the biggest producer of honey in your town",
                "pack://application:,,,/Engine;component/Images/Location/HoneyGarden.png");
            newWorld.AddLocation(2, 0, "Karlo's House",
                "You will receive a quest here",
                "pack://application:,,,/Engine;component/Images/Location/KarloHouse.png");
            return newWorld;
        }
    }
}
