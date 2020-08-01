using Blitzcrank.Character.Player;
using Managers.InputButtons;

namespace Blitzcrank.Manager.Input
{
    public class SecondSkillButton : InputCommand
    {
        public override void Execute(Player player)
        {
            player.PerformSecondSkill();
        }
    }
}