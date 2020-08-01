using Managers.InputButtons;

namespace Blitzcrank.Manager.Input
{
    public class SecondSkillButton : InputCommand
    {
        public override void Execute()
        {
            player.PerformSecondSkill();
        }
    }
}