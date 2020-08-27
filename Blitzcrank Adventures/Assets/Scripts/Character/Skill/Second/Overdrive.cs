using UnityEngine;

namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : ISecondSkillBehavior
    {
        public float Cooldown { get; set; }

        public Overdrive(float cd) => Cooldown = cd;
        
        public void UseSecondSkill()
        {
            if (Cooldown > 0)
            {
                Debug.Log("Overdrive is on cooldown");
            }
            else
            {
                Debug.Log("Overdrive is used");
                Cooldown = 5;
                //FIXME change movement speed here.
            }
        }
    }
}