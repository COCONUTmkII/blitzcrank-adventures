using Blitzcrank.Character.Player;
using UnityEngine;

#region Project namespace

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

