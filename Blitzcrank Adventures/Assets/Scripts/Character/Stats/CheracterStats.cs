using System;
using System.Collections.Generic;
using UnityEngine;

namespace Blitzcrank.Character.Stats
{
    public abstract class CheracterStats: BaseStats
    {
        //TODO: Omg... I'll leave it like this for a while
        public void AddStats(List<StatsModifier> mod)
        {
            foreach (StatsModifier statsModifier in mod)
            {
                if(statsModifier.Stat == Stat.Agility)
                {
                    Agility += statsModifier.Value;
                }
                if(statsModifier.Stat == Stat.Strength)
                {
                    Strength += statsModifier.Value;
                }
            }
        }

        public void RemoveStats(List<StatsModifier> mod)
        {
            foreach (StatsModifier statsModifier in mod)
            {
                if (statsModifier.Stat == Stat.Agility)
                {
                    Agility -= statsModifier.Value;
                }
                if (statsModifier.Stat == Stat.Strength)
                {
                    Strength -= statsModifier.Value;
                }
            }
        }
    }
}