using Blitzcrank.Character.Player;
using UnityEngine;

namespace Managers.InputButtons
{
    public abstract class InputCommand : MonoBehaviour
    {
       public abstract void Execute();
    }
}