using UnityEngine;

namespace Blitzcrank.Character.Skill.Ultimate
{
    public class StaticField : IUltimateSkillBehavior
    {
        public float Cooldown { get; set; }

        public StaticField(float cd) => Cooldown = cd;
        
        public void UseUltimateSkill()
        {
            Debug.Log("Static Field used");
        }
    }
}