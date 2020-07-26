using UnityEngine;
using UnityEngine.UI;

namespace Blitzcrank.UI.Player.Panel
{
    public class HealthBar : MonoBehaviour
    {
        private Slider slider;
        private const string _DEFOUT_HEALT_BAR_BORDER = "Sprite/UI/PlayerPanel/Border/Health_and_energy";
        private Image _icon = null;

        private void Awake()
        {
            _icon = GetComponent<HealthBar>().transform.Find("Border").GetComponent<Image>();
            slider = this.GetComponent<Slider>();
            SetPachToBorder("");
        }
        public void SetMaxHealthPoint(int value)
        {
            slider.maxValue = value;
        }
        public void SetCurentHealthPoint(int value)
        {
            slider.value = value;
        }

        //temporarily so
        public void SetPachToBorder(string customBorder)
        {
            if (customBorder == null || customBorder.Equals(""))
            {
                _icon.sprite = Resources.Load<Sprite>(_DEFOUT_HEALT_BAR_BORDER);
            }
            else
            {
                _icon.sprite = Resources.Load<Sprite>(customBorder);
            }
        }
    }
}

