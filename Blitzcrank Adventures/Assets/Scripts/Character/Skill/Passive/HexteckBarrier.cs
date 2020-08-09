using UnityEngine;

namespace Blitzcrank.Character.Skill.Passive
{
    public class HexteckBarrier : IPassiveSkillBehavior
    {
        public float Cooldown { get; set; }

        public HexteckBarrier(float cd) => Cooldown = cd;
        
        public void UsePassiveSkill()
        {
            if (Cooldown > 0)
            {
                Debug.Log("Hextech Barrier is on a cooldown");
            }
            else
            {
                Debug.Log("Passive is used");
                Cooldown = 10;
            }
        }
    }
}