using UnityEngine;

namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : ISecondSkillBehavior
    {
        public float Cooldown { get; set; }
        private float _timePassedAfterSkillUsed;
        public Overdrive(float cd) => Cooldown = cd;
        
        public void UseSecondSkill()
        {
            _timePassedAfterSkillUsed += Time.deltaTime;
            if (_timePassedAfterSkillUsed > Cooldown)
            {
                Debug.Log("Overdrive is used");
                _timePassedAfterSkillUsed = 0;
            }
            else
            {
                Debug.Log("Overdrive is on cooldown");
            }
        }
    }
}