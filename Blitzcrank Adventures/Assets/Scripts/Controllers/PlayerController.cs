#region Project namespace

using Blitzcrank.Character.Player;
using Blitzcrank.Managers;
using UnityEngine;

#endregion

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Player _movementBehaviour = null;
        void Awake()
        {
            _movementBehaviour = GetComponent<Player>();
            InputManager.Instance.eventPlayerMovementDirectionChanged += OnPlayerMovementDirectionChanged; 
        }

        private void OnDestroy()
        {
            if (InputManager.TryInstance != null)
            {
                InputManager.TryInstance.eventPlayerMovementDirectionChanged -= OnPlayerMovementDirectionChanged;
            }
        }

        private void OnPlayerMovementDirectionChanged(Vector3 targetDirection)
        {
            _movementBehaviour.ChangeCharacterMovementDirection(targetDirection);
        }
    }
}
