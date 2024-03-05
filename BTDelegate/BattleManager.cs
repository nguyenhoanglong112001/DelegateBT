using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class BattleManager
    {
        public void PvE(Chracter player)
        {
            Program.heromanager.CreateEnemy();
            int startbase = player.HP;
            int startenemybase = Program.heromanager.Monster.HP;
            Console.Clear();
            Console.WriteLine($"{player.charatername} info: ");
            Program.uimanager.ShowHero(player);
            Console.WriteLine($"{Program.heromanager.Monster.charatername} info");
            Program.uimanager.ShowHero(Program.heromanager.Monster);
            Console.WriteLine("Press any key to start battle");
            Console.Clear();
            int currentturn = player.atkspeed > 
        }
    }
}
