using System;
using UnityEngine;

namespace Blitzcrank.Character.Skill
{
    public class Cooldown : MonoBehaviour
    {
        private float _timeAfterSkillUse;
        private float _skillCooldown;
        private bool _isCooldown;

        private void Update()
        {
            if (_isCooldown)
            {
                _timeAfterSkillUse += 1 / _skillCooldown * Time.deltaTime;  
                CheckIsSkillUsed();
            }
        }

        private void CheckIsSkillUsed()
        {
            if (_timeAfterSkillUse >= 1)
            {
                Debug.Log("Skill is available to use again");
                _timeAfterSkillUse = 0;
                _isCooldown = false;
            }
        }

        public void SetSkillCooldown(float cd)
        {
            _skillCooldown = cd;
        }

        public bool IsOnCooldown()
        {
            return _isCooldown;
        }

        public void SetIsCooldown(bool isOnCooldown)
        {
            _isCooldown = isOnCooldown;
        }
    }
}