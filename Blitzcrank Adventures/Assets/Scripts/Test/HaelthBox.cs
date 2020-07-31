using UnityEngine;

#region Project namespace
using Blitzcrank.Character.Player;
#endregion

namespace Blitzcrank.Test
{
    //Test class 
    class HaelthBox : MonoBehaviour 
    {
        private void OnTriggerEnter(Collider other)
        {
            other.gameObject.GetComponent<Player>().RecoveryHealth(Random.Range(0, 100));
        }
    }
}
