

using Managers.InputButtons;

namespace Blitzcrank.Manager.Input
{
    public class FirstSkillButton : InputCommand
    {
        public override void Execute()
        {
            player.PerformFirstSkill();
        }
    }
}