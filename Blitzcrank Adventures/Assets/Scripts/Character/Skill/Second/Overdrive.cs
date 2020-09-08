using Blitzcrank.Character.Stats;
using System.Collections.Generic;
using UnityEngine;

namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : ISecondSkillBehavior
    {
        public float TimePassedAfterUsedSkill { get; set; }
        public float Cooldown { get; set; }
        private Cooldown _cooldown;
        public Overdrive(Cooldown cooldown, float cd)
        {
            _cooldown = cooldown;
            _cooldown.SetSkillCooldown(cd);
        }
        public int Level { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public (int time, List<StatsModifier> mod) UseSecondSkill()
        {
            List<StatsModifier> statsListMod = new List<StatsModifier>();
            if (_cooldown.IsOnCooldown())
            {
                Debug.Log("Skill is on cooldown");
            }
            else
            {
                statsListMod.Add(new StatsModifier(Stat.Agility, 2, StatsModType.Flat));
                _cooldown.SetIsCooldown(true);
                Debug.Log("Overdrive is used");
                return (time: 5, mod: statsListMod);
            }
            return (time: 0, mod: statsListMod);
        }
    }
}