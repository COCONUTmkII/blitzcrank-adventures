using Blitzcrank.Character.Player;
using UnityEngine;

namespace Managers.InputButtons
{
    public abstract class InputCommand
    {
        public abstract void Execute(Player player);

    }
}