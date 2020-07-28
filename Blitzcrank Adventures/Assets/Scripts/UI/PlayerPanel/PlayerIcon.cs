using UnityEngine;
using UnityEngine.UI;

namespace Blitzcrank.UI.Player.Panel
{
    class PlayerIcon : MonoBehaviour
    {   //Default icon, loading from resources (LoadManager)
        private const string _DEFOUT_CHARACTER_ICON= "Sprite/UI/PlayerPanel/Icon/Defoult_Blitzcrank_icon";
        private Image _icon = null;
        public void Awake()
        {
            _icon = GetComponent<PlayerIcon>().transform.Find("Icon").GetComponent<Image>();
            //Test loading a character icon from UIManager? LoadManager
            SetPachToIcon("");
        }
        public void SetPachToIcon(string customIcon)
        {
            if (customIcon.Equals(""))
            {
                _icon.sprite = Resources.Load<Sprite>(_DEFOUT_CHARACTER_ICON);
            }
            else
            {
                _icon.sprite = Resources.Load<Sprite>(customIcon);
            }
        }
    }
}
