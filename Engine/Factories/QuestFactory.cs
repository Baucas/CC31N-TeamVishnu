using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9001, 25));
            itemsToComplete.Add(new ItemQuantity(9002, 75));
            itemsToComplete.Add(new ItemQuantity(9003, 100));
            rewardItems.Add(new ItemQuantity(1002, 6));

            List<ItemQuantity> itemsToComplete1 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems1 = new List<ItemQuantity>();
            itemsToComplete1.Add(new ItemQuantity(9004, 25));
            itemsToComplete1.Add(new ItemQuantity(9005, 75));
            itemsToComplete1.Add(new ItemQuantity(9006, 100));
            rewardItems1.Add(new ItemQuantity(1002, 5));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();
            itemsToComplete2.Add(new ItemQuantity(9007, 75));
            itemsToComplete2.Add(new ItemQuantity(9008, 100));
            rewardItems2.Add(new ItemQuantity(1002, 7));

            _quests.Add(new Quest(1,
                                  "Defeat the bears in the Honey Garden.",
                                  "Collect drops",
                                  itemsToComplete,
                                  50, 100,
                                  rewardItems));

            _quests.Add(new Quest(2,
                                  "Kill the anaconda that is eating my livestocks.",
                                  "Collect drops.",
                                  itemsToComplete,
                                  60, 100,
                                  rewardItems1));
            _quests.Add(new Quest(3,
                                  "Kill the boar's that is eating my plants.",
                                  "Collect drops.",
                                  itemsToComplete,
                                  30, 60,
                                  rewardItems2));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
 