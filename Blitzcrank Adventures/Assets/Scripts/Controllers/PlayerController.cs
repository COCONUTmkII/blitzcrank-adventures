using UnityEngine;

#region Project namespace
using Blitzcrank.Manager;
using Blitzcrank.Character.Player;
#endregion

namespace Blitzcrank.Controller
{
    public class PlayerController : MonoBehaviour
    {
        private Player _movementBehaviour = null;
        void Awake()
        {
            _movementBehaviour = GetComponent<Player>();
            InputManager.Instance.EventPlayerMovementDirectionChanged += OnPlayerMovementDirectionChanged; 
        }

        private void OnDestroy()
        {
            if (InputManager.TryInstance != null)
            {
                InputManager.TryInstance.EventPlayerMovementDirectionChanged -= OnPlayerMovementDirectionChanged;
            }
        }

        private void OnPlayerMovementDirectionChanged(Vector3 targetDirection)
        {
            _movementBehaviour.ChangeCharacterMovementDirection(targetDirection);
        }
    }
}
