using UnityEngine;

namespace CharacterBehaviours
{
    public class CharacterMovementBehaviour : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 15f;
        [SerializeField] private float velocityChangeSpeed = 15f;
        private Vector3 _targetMovementVelocity = Vector3.zero;
        private Vector3 _currentMovementVelocity;
        private Rigidbody _rigidBody;

        void Start()
        {
            _rigidBody = GetComponent<Rigidbody>();
        }
    
        void Update()
        {
            _currentMovementVelocity = Vector3.Lerp(
                _currentMovementVelocity, _targetMovementVelocity * movementSpeed, velocityChangeSpeed * Time.deltaTime);
        }
        void FixedUpdate()
        {
            _rigidBody.velocity = new Vector3(_currentMovementVelocity.x, _rigidBody.velocity.y, _currentMovementVelocity.z);
        }

        public void ChangeCharacterMovementDirection (Vector3 targetDirection)
        {
            _targetMovementVelocity = targetDirection.normalized;
        }
    }
}
