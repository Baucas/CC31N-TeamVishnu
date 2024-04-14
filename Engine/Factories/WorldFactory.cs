using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Home",
                "This is your home",
                "Home.png");


            newWorld.AddLocation(0, -1, "Town Hall",
                "The town hall is so common",
                "TownHall.png");
            newWorld.LocationAt(0, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(1, -1, "Town's Gate",
                "You're friend is working here, you should greet him",
                "TownGate.png");

            newWorld.AddLocation(2, -1, "Shop",
                "All you need is here",
                "Shop.png");
            newWorld.LocationAt(2, -1).TraderHere =
                TraderFactory.GetTraderByName("Trick");

            newWorld.AddLocation(3, -1, "Mark Anthony's House",
                "Please help me kill the anaconda that is eating all my livestock",
                "MarkHouse.png");

            newWorld.LocationAt(3, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(4, -1, "Mark's Farm",
                "There is a rumor that the anaconda has a companion",
                "MarkFarm.png");
            newWorld.LocationAt(4, -1).AddMonster(3, 100);

            newWorld.AddLocation(2, 1, "Healing Fountain",
                "What a beautiful fountain",
                "HealingFountain.png");

            newWorld.AddLocation(1, 1, "Acorn Garden",
                "There are many boars, you should kill them",
                "AcornGarden.png");
            newWorld.LocationAt(1, 1).AddMonster(2, 100);

            newWorld.AddLocation(3, 1, "Bear",
                "There is one bear that lost its direction",
                "Bear.png");

            newWorld.AddLocation(4, 1, "Karlo's Honey Garden",
                "There are bears that are destroying the biggest producer of honey in your town",
                "HoneyGarden.png");
            newWorld.LocationAt(4, 1).AddMonster(1, 100);

            newWorld.AddLocation(2, 0, "Karlo's House",
                "You will receive a quest here",
                "KarloHouse.png");
            newWorld.LocationAt(2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            return newWorld;
        }
    }
}

