namespace Blitzcrank.Character.Skill
{
    public interface ISecondSkillBehavior
    {
        float Cooldown
        {
            get;
            set;
        }
        
        void UseSecondSkill();
    }
}