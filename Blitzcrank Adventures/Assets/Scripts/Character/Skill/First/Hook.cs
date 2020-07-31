namespace Blitzcrank.Character.Skill.First
{
    public class Hook : IFirstSkillBehavior
    {
        public float Cooldown { get; set; }

        public Hook(float cd) => Cooldown = cd;
        public void UseFirstSkill()
        {
            throw new System.NotImplementedException();
        }
    }
}