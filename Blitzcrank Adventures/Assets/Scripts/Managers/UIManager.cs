using UnityEngine;

#region Project name area
using Blitzcrank.Common;
using Blitzcrank.Character.Player;
using Blitzcrank.UI.Player.Panel;
#endregion

namespace Blitzcrank.Manager
{
    class UIManager : SingletonGameObject<UIManager>
    {
        [SerializeField] private Player player = null;
        [SerializeField] private HealthBar healthBar = null;
        [SerializeField] private EnergyBar energyBar = null;
        private void Start()
        {
            healthBar.SetMaxHealthPoint(player.MaxHealthPoints);
            energyBar.SetMaxEnergyPoint(player.MaxEnergyPoints);
        }
        void OnEnable()
        {
            Player.HealthPointsEvent += HealthPoints;
            Player.EnergyPointsEvent += EnergyPoints;
        }
        void OnDisable()
        {
            Player.HealthPointsEvent -= HealthPoints;
            Player.EnergyPointsEvent -= EnergyPoints;
        }
        void HealthPoints(int value)
        {
            healthBar.SetCurentHealthPoint(value);
        }
        void EnergyPoints(int value)
        {
            energyBar.SetCurentEnergyPoint(value);
        }
    }
}

