

using Managers.InputButtons;

namespace Blitzcrank.Manager.Input
{
    public class FirstSkillButton : InputCommand
    {
        public delegate void FirstSkillDelegate();
        public static event FirstSkillDelegate FirstSkillEvent;
        public override void Execute()
        {
            FirstSkillEvent();
            //player.PerformFirstSkill();
        }
    }
}