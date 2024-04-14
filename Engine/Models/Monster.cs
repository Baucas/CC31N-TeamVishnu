using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }
        public int RewardExperiencePoints { get; }
        public int MinimumDamage { get; internal set; }
        public int MaximumDamage { get; internal set; }

        public Monster(string name, string imageName,
                       int maximumHitPoints, int currentHitPoints,
                       int rewardExperiencePoints, int gold, int v) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            RewardExperiencePoints = rewardExperiencePoints;
        }

        public Monster(string name, string imageName, int maximumHitPoints, int currentHitPoints, int rewardExperiencePoints, int gold, int v, int v1) : this(name, imageName, maximumHitPoints, currentHitPoints, rewardExperiencePoints, gold, v)
        {
        }
    }
}
