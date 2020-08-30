using Blitzcrank.Character.Stats;
using System.Collections.Generic;

namespace Blitzcrank.Character.Skill
{
    public interface ISecondSkillBehavior
    {
        int Level { get; set; }
        (int time, List<StatsModifier> mod) UseSecondSkill();
    }
}