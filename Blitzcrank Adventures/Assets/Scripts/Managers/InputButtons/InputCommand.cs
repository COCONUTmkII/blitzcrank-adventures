using Blitzcrank.Character.Player;
using UnityEngine;

namespace Managers.InputButtons
{
    public abstract class InputCommand : MonoBehaviour
    {
       [SerializeField] protected Player player; //TODO fix this
       public abstract void Execute();
    }
}