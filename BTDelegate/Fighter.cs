using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Fighter : Chracter
    {
        public Fighter(CharacterType Type, string name) : base(Type, name)
        {
            attack = GameHelper.Randomvalue(80, 100);
            powerdame = GameHelper.Randomvalue(0, 10);
            HP = GameHelper.Randomvalue(700, 1000);
            atkspeed = GameHelper.Randomvalue(10, 50);
        }
    }
}
