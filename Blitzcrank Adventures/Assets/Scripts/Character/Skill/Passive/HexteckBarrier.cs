using UnityEngine;

namespace Blitzcrank.Character.Skill.Passive
{
    public class HexteckBarrier : IPassiveSkillBehavior
    {
        public float Cooldown { get; set; }

        public HexteckBarrier(float cd) => Cooldown = cd;
        
        public void UsePassiveSkill()
        {
            Debug.Log("Passive is used");           
        }
    }
}