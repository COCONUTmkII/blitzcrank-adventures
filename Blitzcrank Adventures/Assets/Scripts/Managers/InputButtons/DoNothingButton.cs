using Managers.InputButtons;
using UnityEngine;

namespace Blitzcrank.Manager.Input
{
    public class DoNothingButton : InputCommand
    {
        public override void Execute()
        {
            Debug.Log("This button do nothing");
        }
    }
}