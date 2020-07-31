using Blitzcrank.Character.Skill;
using UnityEngine;

namespace Blitzcrank.Character
{
    public abstract class Character : Stats
    {
        /// <summary>
        /// This region represents skills of characters that will use them.
        /// This skills can be used by player and bosses/enemy's also.
        /// </summary>
        #region Skill Sets
        private IPassiveSkillBehavior _passiveSkill;
        private IFirstSkillBehavior _firstSkill;
        private ISecondSkillBehavior _secondSkill;
        private IThirdSkillBehavior _thirdSkill;
        private IUltimateSkillBehavior _ultimateSkill;
        #endregion
        
        public bool Immortal { get; set; }
        public bool IsAlive { get; set; }
        /// <summary>
        /// Method which invoked when each character receive damage; 
        /// </summary>
        public virtual void GetDamage(int damage)
        {
            if ((CurrentHealthPoints > damage && Immortal != true) && IsAlive)
            {
                CurrentHealthPoints -= damage; // We will decide implementation later
                Debug.Log("Character takes <color=red>" + damage + " damage</color> points.");
            }
            else if (CurrentHealthPoints <= damage && IsAlive)
            {
                CurrentHealthPoints = 0;
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
            if (CurrentHealthPoints < MaxHealthPoints && IsAlive)
            {
                if ((MaxHealthPoints - CurrentHealthPoints) >= health)
                {
                    CurrentHealthPoints += health;
                    Debug.Log("Character restore <color=green>" + health + " health</color> points.");
                }
                else
                {
                    CurrentHealthPoints = MaxHealthPoints;
                    Debug.Log("<color=green>Full health</color>.");
                }
            }
        }

        public virtual void EnergyExpended(int energy)
        {
            if(CurrentEnergyPoints > energy && IsAlive)
            {
                CurrentEnergyPoints -= energy;
                Debug.Log("<color=blue>" + energy + " energy</color> point expended.");
            }
            else if(CurrentEnergyPoints < energy && IsAlive)
            {
                Debug.Log("<color=blue>Energy is too low</color>");
            }
            else if(CurrentEnergyPoints == energy && IsAlive)
            {
                CurrentEnergyPoints = 0;
            }
        }

        public virtual void RecoveryEnergy(int energy)
        {
            if (CurrentEnergyPoints <= MaxEnergyPoints && IsAlive)
            {
                if ((MaxEnergyPoints - CurrentEnergyPoints) >= energy)
                {
                    CurrentEnergyPoints += energy;
                    Debug.Log("Character restore <color=blue>" + energy + " energy</color> points.");
                }
                else
                {
                    CurrentEnergyPoints = MaxEnergyPoints;
                    Debug.Log("<color=blue>Full enegy</color>.");
                }
            }
        }
        
        /// <summary>
        /// This methods used to perform action of skill.
        /// </summary>
        #region Skill Perform
        public void PerformPassiveSkill()
        {
            _passiveSkill.UsePassiveSkill();
        }

        public void PerformFirstSkill()
        {
            _firstSkill.UseFirstSkill();
        }

        public void PerformSecondSkill()
        {
            _secondSkill.UseSecondSkill();
        }

        public void PerformThirdSkill()
        {
            _thirdSkill.UseThirdSkill();
        }

        public void PerformUltimateSkill()
        {
            _ultimateSkill.UseUltimateSkill();
        }
        #endregion
        
        /// <summary>
        /// This methods are used to change skill of player when player will decide to do that
        /// </summary>
        #region Set skills
        public void SetPassiveSkill(IPassiveSkillBehavior passiveSkill)
        {
            _passiveSkill = passiveSkill;
        }
        
        public void SetFirstSkill(IFirstSkillBehavior firstSkill)
        {
            _firstSkill = firstSkill;
        }

        public void SetSecondSkill(ISecondSkillBehavior secondSkill)
        {
            _secondSkill = secondSkill;
        }

        public void SetThirdSkill(IThirdSkillBehavior thirdSkill)
        {
            _thirdSkill = thirdSkill;
        }

        public void SetUltimateSkill(IUltimateSkillBehavior ultimateSkill)
        {
            _ultimateSkill = ultimateSkill;
        }
        #endregion
    }
}
