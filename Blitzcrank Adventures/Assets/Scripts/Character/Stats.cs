using UnityEngine;

namespace Blitzcrank.Character
{
    public abstract class Stats : MonoBehaviour
    {
        //Different meanings for different characters
        [SerializeField] private int Strength = 0;
        [SerializeField] private int Energy = 0;

        #region Health
        public int MaxHealthPoints {
            get {
                return Strength * 5;
            }
        }
        public int CurentHealthPoints { get; set; }
        #endregion

        #region Energy
        public virtual int MaxEnergyPoints {
            get {
                return Energy * 2;
            }
        }
        public int CurentEnergyPoints { get; set; }
        #endregion
    }
}