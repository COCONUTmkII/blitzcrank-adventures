using Blitzcrank.Character.Player;
using UnityEngine;

#region Project namespace

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
