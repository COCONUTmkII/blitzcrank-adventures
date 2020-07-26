using UnityEngine;

#region Project namespace
using Blitzcrank.Character.Player;
#endregion
/// <summary>
/// This class is used for simple test cases of character stats and this class could be deleted or changed later
/// </summary>

namespace Blitzcrank.GeameHandler
{
    public class GameHandler : MonoBehaviour
    {
        [SerializeField] private Player player = null; //Ignor
        private void Start()
        {
            ///<summary>
            ///Simulate loading player parameters
            ///</summary>
            
            player.IsAlive = true;
            player.Immortel = false;
            player.RecoveryHealth(100);
            player.RecoveryEnergy(30);
        }
    }
}

