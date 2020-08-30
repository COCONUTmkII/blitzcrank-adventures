using System;
using Blitzcrank.Managers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Blitzcrank.Character.Player
{
    public class Player : Character
    {
        public delegate void HealthPointsDelegate(int value);
        public static event HealthPointsDelegate HealthPointsEvent;
        public delegate void EnergyPointsDelegate(int value);
        public static event EnergyPointsDelegate EnergyPointsEvent;
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
            _currentMovementVelocity, _targetMovementVelocity * MaxMovementSpeed, velocityChangeSpeed * Time.deltaTime);
        }

        void FixedUpdate()
        {
            _rigidBody.velocity = new Vector3(_currentMovementVelocity.x, _rigidBody.velocity.y, _currentMovementVelocity.z);
        }
        
        public void ChangeCharacterMovementDirection(Vector3 targetDirection)
        {
            _targetMovementVelocity = targetDirection.normalized;
        }
     
        public override void GetDamage(int damage){
            base.GetDamage(damage);
            HealthPointsEvent(CurrentHealthPoints);
        }

        public override void RecoveryHealth(int health)
        {
            base.RecoveryHealth(health);
            HealthPointsEvent(CurrentHealthPoints);
        }

        public override void EnergyExpended(int energy)
        {
            base.EnergyExpended(energy);
            EnergyPointsEvent(CurrentEnergyPoints);
        }

        public override void RecoveryEnergy(int energy)
        {
            base.RecoveryEnergy(energy);
            EnergyPointsEvent(CurrentEnergyPoints);
        }
    }
}







