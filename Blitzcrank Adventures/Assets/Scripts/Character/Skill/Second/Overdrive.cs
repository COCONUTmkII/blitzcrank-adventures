using Blitzcrank.Character.Stats;
using System.Collections.Generic;
using UnityEngine;

namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : ISecondSkillBehavior
    {
        
        public float overdriveCooldown = 15;
        private float _timePassedAfterSkillUsed = 15;

        public int Level { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public (int time, List<StatsModifier> mod) UseSecondSkill()
        {
            List<StatsModifier> statsListMod = new List<StatsModifier>();
            Debug.Log(_timePassedAfterSkillUsed);
            if (_timePassedAfterSkillUsed >= overdriveCooldown)
            {
                Debug.Log(_timePassedAfterSkillUsed);
                Debug.Log("Overdrive is used");
                statsListMod.Add(new StatsModifier(Stat.Agility, 2, StatsModType.Flat));
                statsListMod.Add(new StatsModifier(Stat.Strength, 5, StatsModType.Flat));
                _timePassedAfterSkillUsed = 0;
            }
            else
            {
                Debug.Log("Overdrive is on cooldown");               
            }
            _timePassedAfterSkillUsed += Time.deltaTime * 100;
            return (time: 5, mod: statsListMod);
        }
    }
}