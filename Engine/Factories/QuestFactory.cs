using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class QuestFactory
    {
        private static List<Quest> _quests;

        static QuestFactory()
        {
            _quests = new List<Quest>
            {
                new Quest
                {
                    ID = 1,
                    Name = "Town Mayor",
                    Description = "Kill the bears in the honey garden.",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity(10, 5)
                    },
                    RewardExpPoints = 100,
                    RewardGold = 100,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity(201, 1)
                    }
                },

                new Quest
                {
                    ID = 2,
                    Name = "Mark",
                    Description = "Kill the anaconda that is eating my livestocks.",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity(11, 1)
                    },
                    RewardExpPoints = 75,
                    RewardGold = 75,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity(201, 1)
                    }
                },

                new Quest
                {
                    ID = 3,
                    Name = "Karlo",
                    Description = "Kill the boar's that is eating my plants.",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity(10, 5)
                    },
                    RewardExpPoints = 90,
                    RewardGold = 60,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity(201, 1)
                    }
                },
            };
        }

        internal static Quest GetQuestByID(int questID)
        {
            return _quests.FirstOrDefault(q => q.ID == questID);
        }
    }
}
 