using Blitzcrank.Character.Player;
using Blitzcrank.Character.Skill.First;
using Blitzcrank.Character.Skill.Passive;
using Blitzcrank.Character.Skill.Second;
using Blitzcrank.Character.Skill.Third;
using Blitzcrank.Character.Skill.Ultimate;
using UnityEngine;


//This class is used for simple test cases of character stats and this class could be deleted or changed later
namespace Blitzcrank.GameHandler
{
    public class GameHandler : MonoBehaviour
    {
        [SerializeField] private Player player; //Ignore
        private void Start()
        {
            //Simulate loading player parameters
            player.IsAlive = true;
            player.Immortal = false;
            player.RecoveryHealth(100);
            player.RecoveryEnergy(30);
            player.SetPassiveSkill(new HexteckBarrier());
            player.SetFirstSkill(new Hook());
            player.SetSecondSkill(new Overdrive());
            player.SetThirdSkill(new PowerFist());
            player.SetUltimateSkill(new StaticField());
            player.PerformPassiveSkill();
            player.PerformFirstSkill();
            player.PerformSecondSkill();
            player.PerformThirdSkill();
            player.PerformUltimateSkill();
        }
    }
}

