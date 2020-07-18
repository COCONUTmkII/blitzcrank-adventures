using CharacterBehaviours;
using Managers;
using UnityEngine;

namespace Controllers
{
    public class PlayerCharacterController : MonoBehaviour
    {
        private CharacterMovementBehaviour _movementBehaviour;
        void Awake()
        {
            _movementBehaviour = GetComponent<CharacterMovementBehaviour>();

            InputManager.Instance.eventPlayerMovementDirectionChanged += OnPlayerMovementDirectionChanged;
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        private void OnDestroy()
        {
            if (InputManager.TryInstance != null)
            {
                InputManager.TryInstance.eventPlayerMovementDirectionChanged -= OnPlayerMovementDirectionChanged;
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnPlayerMovementDirectionChanged (Vector3 targetDirection)
        {
            _movementBehaviour.ChangeCharacterMovementDirection(targetDirection);
        }
    }
}
