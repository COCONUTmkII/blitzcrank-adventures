using UnityEngine;

namespace Blitzcrank.Character
{
    public abstract class Stats : MonoBehaviour
    {
        //Different meanings for different characters
        [SerializeField] private int Strength = 0;
        [SerializeField] private int Energy = 0;

        #region Health
        //The maximum number of character health points depending on his strength
        //For example: one point of strength gives five points of character health
        public int MaxHealthPoints {
            get {
                return Strength * 5;
            }
        }
        //When initializing a character, restore his health to the required
        public int CurrentHealthPoints { get; set; }
        #endregion

        #region Energy
        public virtual int MaxEnergyPoints {
            get {
                return Energy * 2;
            }
        }
        public int CurrentEnergyPoints { get; set; }
        #endregion
    }
}