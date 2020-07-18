namespace CharacterBehaviours.MainCharacter
{
    public class MainCharacter : Character
    {
        public override void GetDamage(float damage)
        {
            Health -= damage; // We will decide implementation later
        }
        /// <summary>
        /// Heals main character to some amount.
        /// Maybe we will change this method destination because Bosses could heal too.
        /// </summary>
        /// <param name="health">Heal amount</param>
        public void HealBlitzcrank(float health)
        {
            Health += health;
        }
    }
}