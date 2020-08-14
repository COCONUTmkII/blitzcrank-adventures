using UnityEditor.UIElements;
using UnityEngine;

namespace Blitzcrank.Character
{
    public abstract class Stats : MonoBehaviour
    {
        //Different meanings for different characters
        [SerializeField] private int Strength = 0;
        [SerializeField] private int Energy = 0;
        [SerializeField] private int Agility = 5;
    
        /// <summary>
        /// The maximum number of movement speed of character depending on his agility
        /// E.g.: one point of agility gives 3 points of character movement speed
        /// </summary>
        #region MovementSpeed
        public float MaxMovementSpeed
        {
            get
            {
                return Agility * 3;
            }
        }

        public float CurrentMovementSpeed
        {
            get => Agility;
            set => Agility = (int) value;
        }
        #endregion

        
        #region Health
        //The maximum number of character health points depending on his strength
        //For example: one point of strength gives five points of character health
        public int MaxHealthPoints => Strength * 5;
        //When initializing a character, restore his health to the required
        public int CurrentHealthPoints { get; set; }
        #endregion

        #region Energy
        public virtual int MaxEnergyPoints => Energy * 2;
        public int CurrentEnergyPoints { get; set; }
        #endregion
    }
}