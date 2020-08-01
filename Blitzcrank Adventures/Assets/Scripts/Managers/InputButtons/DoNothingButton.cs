using Blitzcrank.Character.Player;
using Managers.InputButtons;
using UnityEngine;

namespace Blitzcrank.Manager.Input
{
    public class DoNothingButton : InputCommand
    {
        public override void Execute(Player player)
        {
            Debug.Log("This button do nothing");
        }
    }
}