using System;
using System.Collections.Generic;
using System.Linq;
using Managers.InputButtons;
using UnityEngine;

namespace Blitzcrank.Manager.Input
{
    public class InputButtonListener
    {
        private static  Dictionary<KeyCode, InputCommand> _buttons;
        private static InputCommand _command; 
            
        static InputButtonListener()
        {
            Dictionary<KeyCode, InputCommand> buttons = new Dictionary<KeyCode, InputCommand>
            {
                {KeyCode.Alpha1, new FirstSkillButton()},
                {KeyCode.Alpha2, new SecondSkillButton()},
                {KeyCode.Alpha3, new ThirdSkillButton()},
                {KeyCode.Alpha4, new UltimateSkillButton()}
            };
            _buttons = new Dictionary<KeyCode, InputCommand>(buttons);
        }

        public static InputCommand CheckInputButton(KeyCode keyCode)
        {
            Debug.Log(_buttons.Values);
            if (_buttons.TryGetValue(keyCode, out _command))
            {
                return _command;
            }
            return new DoNothingButton();
        }
    }
}