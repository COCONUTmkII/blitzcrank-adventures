using UnityEngine;

#region Project namespace
using Blitzcrank.Character.Player;
#endregion

namespace Blitzcrank.Test
{
    class DamageBox : MonoBehaviour
    {
        //Test class 
        private void OnTriggerEnter(Collider other)
        {
            other.gameObject.GetComponent<Player>().GetDamage(Random.Range(0, 100));
        }
    }
}
