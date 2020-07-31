using UnityEngine;

#region Project namespace
using Blitzcrank.Character.Player;
#endregion

namespace Blitzcrank.Test
{
    public class EnergyBox : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            other.gameObject.GetComponent<Player>().RecoveryEnergy(Random.Range(0, 20));
        }
    }
}

