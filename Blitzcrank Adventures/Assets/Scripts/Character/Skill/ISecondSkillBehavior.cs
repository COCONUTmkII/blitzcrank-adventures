namespace Blitzcrank.Character.Skill
{
    public abstract class SecondSkillBehavior
    {
       float Cooldown { get; set; }
       public delegate void SecondSkillDelegate(float value);

       public static event SecondSkillDelegate SecondSkillEvent;

       public virtual void UseSecondSkill(float stat)
       {
           SecondSkillEvent(stat);
       }
       
       
    }
}