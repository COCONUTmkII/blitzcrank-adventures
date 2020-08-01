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
        [SerializeField] private Player player = null; //Ignore
        private void Start()
        {
            //Simulate loading player parameters
            player.IsAlive = true;
            player.Immortal = false;
            player.RecoveryHealth(100);
            player.RecoveryEnergy(30);
            player.SetPassiveSkill(new HexteckBarrier(5));
            player.SetFirstSkill(new Hook(5));
            player.SetSecondSkill(new Overdrive(6));
            player.SetThirdSkill(new PowerFist(7));
            player.SetUltimateSkill(new StaticField(20));
        }
    }
}

