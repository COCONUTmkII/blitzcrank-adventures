using UnityEngine;

#region Project namespace
using Blitzcrank.Character.Player;
using Blitzcrank.Manager;
#endregion

public class PlayerCharacterController : MonoBehaviour
{
    private Player _movementBehaviour = null;
    void Awake()
    {
        _movementBehaviour = GetComponent<Player>();

        InputManager.Instance.EventPlayerMovementDirectionChanged += OnPlayerMovementDirectionChanged;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDestroy()
    {
        if (InputManager.TryInstance != null)
        {
            InputManager.TryInstance.EventPlayerMovementDirectionChanged -= OnPlayerMovementDirectionChanged;
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
