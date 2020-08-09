using UnityEngine;

namespace Blitzcrank.Character.Skill.Third
{
    public class PowerFist : IThirdSkillBehavior
    {
        public float Cooldown { get; set; }

        public PowerFist(float cd) => Cooldown = cd;
        
        public void UseThirdSkill()
        {
            Debug.Log("PowerFist used");
        }
    }
}