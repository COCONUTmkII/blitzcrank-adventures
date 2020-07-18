using UnityEngine;

namespace CharacterBehaviours
{
    public abstract class Character
    {
        #region BasicCharacterField
        private bool _isAlive;
        private float _health;
        private float _mana;
        // other fields that indicates to all characters will be placed here
        #endregion

        #region BasicCharacterFieldProperty
        public bool IsAlive
        {
            get => _isAlive;
            set => _isAlive = value;
        }

        public float Health
        {
            get => _health;
            set => _health = value;
        }

        public float Mana
        {
            get => _mana;
            set => _mana = value;
        }
        #endregion
        
        /// <summary>
        /// Method which invoked when each character receive damage; 
        /// </summary>
        public abstract void GetDamage(float damage);
    }
}