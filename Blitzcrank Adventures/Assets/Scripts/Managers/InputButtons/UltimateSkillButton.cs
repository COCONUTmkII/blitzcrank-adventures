using Managers.InputButtons;

namespace Blitzcrank.Manager.Input
{
    public class UltimateSkillButton : InputCommand
    {
        public override void Execute()
        {
            player.PerformUltimateSkill();
        }
    }
}