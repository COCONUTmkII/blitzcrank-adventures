using CharacterBehaviours.MainCharacter;
using UnityEngine;

namespace GameHandler
{
    /// <summary>
    /// This class is used for simple test cases of character stats and this class could be deleted or changed later
    /// </summary>
    public class GameHandler : MonoBehaviour
    {
        private void Start()
        {
            MainCharacter mainCharacter = new MainCharacter {Health = 30, Mana = 20, IsAlive = true};

            Debug.Log("Health" + mainCharacter.Health);

            mainCharacter.GetDamage(10);
            
            Debug.Log("Health" + mainCharacter.Health);

            mainCharacter.HealBlitzcrank(10);
            
            Debug.Log("Health" + mainCharacter.Health);
            
        }
    }
}