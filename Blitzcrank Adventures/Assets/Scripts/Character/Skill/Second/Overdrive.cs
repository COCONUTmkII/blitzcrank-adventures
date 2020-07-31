namespace Blitzcrank.Character.Skill.Second
{
    public class Overdrive : ISecondSkillBehavior
    {
        public float Cooldown { get; set; }

        public Overdrive(float cd) => Cooldown = cd;
        
        public void UseSecondSkill()
        {
            throw new System.NotImplementedException();
        }
    }
}