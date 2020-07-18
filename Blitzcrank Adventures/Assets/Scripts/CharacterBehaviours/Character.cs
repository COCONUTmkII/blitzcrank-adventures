using UnityEngine;

namespace CharacterBehaviours
{
    public abstract class Character
    {
        #region BasicCharacterFieldProperty
        public bool IsAlive { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }
        #endregion
        
        /// <summary>
        /// Method which invoked when each character receive damage; 
        /// </summary>
        public abstract void GetDamage(float damage);
    }
}