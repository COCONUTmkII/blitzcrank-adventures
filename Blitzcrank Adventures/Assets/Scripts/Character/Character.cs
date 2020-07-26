using UnityEngine;

namespace Blitzcrank.Character
{
    public abstract class Character : Stats
    {

        public bool Immortel { get; set; }
        public bool IsAlive { get; set; }
        /// <summary>
        /// Method which invoked when each character receive damage; 
        /// </summary>
        public virtual void GetDamage(int damage)
        {
            if ((CurentHealthPoints > damage && Immortel != true) && IsAlive != false)
            {
                CurentHealthPoints -= damage; // We will decide implementation later
                Debug.Log("Character takes <color=red>" + damage + " damage</color> points.");
            }
            else if (CurentHealthPoints <= damage)
            {
                CurentHealthPoints = 0;
                IsAlive = false;
                Debug.Log("<color=red>CHARACTER DIED</color>.");
            }
        }
        /// <summary>
        /// Heals main character to some amount.
        /// Maybe we will change this method destination because Bosses could heal too.
        /// </summary>
        /// <param name="health">Heal amount</param>
        public virtual void RecoveryHealth(int health)
        {
            if (CurentHealthPoints < MaxHealthPoints && IsAlive == true)
            {
                if ((MaxHealthPoints - CurentHealthPoints) >= health)
                {
                    CurentHealthPoints += health;
                    Debug.Log("Character restore <color=green>" + health + " health</color> points.");
                }
                else
                {
                    CurentHealthPoints = MaxHealthPoints;
                    Debug.Log("<color=green>Full health</color>.");
                }
            }
        }

        public virtual void EnergyExpended(int energy)
        {
            if(CurentEnergyPoints > energy)
            {
                CurentEnergyPoints -= energy;
                Debug.Log("<color=blue>" + energy + "energy point expended.");
            }
            else
            {
                Debug.Log("<color=blue>Energy is too low</color>");
            }

        }

        public virtual void RecoveryEnergy(int energy)
        {
            if (CurentEnergyPoints < MaxEnergyPoints && IsAlive == true)
            {
                if ((MaxEnergyPoints - CurentEnergyPoints) >= energy)
                {
                    CurentEnergyPoints += energy;
                    Debug.Log("Character restore <color=blue>" + energy + " energy</color> points.");
                }
                else
                {
                    CurentEnergyPoints = MaxHealthPoints;
                    Debug.Log("<color=blue>Full enegy</color>.");
                }
            }

        }
    }
}
