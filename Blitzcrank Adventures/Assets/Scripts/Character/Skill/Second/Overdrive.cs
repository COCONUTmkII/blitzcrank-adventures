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
            CheckIsSkillReady();
            List<StatsModifier> statsListMod = new List<StatsModifier>
            {
                new StatsModifier(Stat.Agility, 2, StatsModType.Flat),
                new StatsModifier(Stat.Strength, 5, StatsModType.Flat)
            };
            return (time: 5, mod: statsListMod);
        }

        private void CheckIsSkillReady()
        {
            if (_cooldown.IsOnCooldown())
            {
                Debug.Log("Skill is on cooldown");
            }
            else
            {
                Debug.Log("Overdrive is used");
                _cooldown.SetIsCooldown(true);
            }
        }
    }
}