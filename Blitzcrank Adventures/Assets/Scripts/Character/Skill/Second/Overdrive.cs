using UnityEngine;

namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : SecondSkillBehavior
    {
        [SerializeField] private Stats _stats;
        public float Cooldown { get; set; }
        public Overdrive(float cd) => Cooldown = cd;
        
        public override void UseSecondSkill()
        {
            Debug.Log("Cooldown of OVERDRIVE IS " + Cooldown);
            if (Cooldown > 0)
            {
                Debug.Log("Overdrive is on cooldown");
            }
            else
            {
                Debug.Log("Overdrive is used");
                _stats.CurrentMovementSpeed = 10;      
                Debug.Log("Movement speed increased to" + _stats.CurrentMovementSpeed);
                Cooldown = 5;
            }
        }
    }
}