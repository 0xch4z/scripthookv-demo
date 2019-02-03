using System.Windows.Forms;
using GTA;
using GTA.Math;


namespace NPCAttack
{
    /// <summary>
    /// Attacker
    /// </summary>
    public class Attacker : Script
    {
        public Attacker()
        {
            this.KeyDown += onKeyDown;
        }

        private void onKeyDown(object sender, KeyEventArgs evt)
        {
            if (evt.KeyCode == Keys.F4)
            {
                var npc = World.CreatePed(GTA.Native.PedHash.Abigail, Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0, 5, 0)));
                npc.Weapons.Give(GTA.Native.WeaponHash.RPG, 5, true, true);
                npc.Task.FightAgainst(Game.Player.Character);
            }
        }
    }
}
