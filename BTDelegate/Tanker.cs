using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Tanker : Chracter
    {
        public Tanker(CharacterType type, string name) : base(type,name)
        {
            attack = GameHelper.Randomvalue(50, 80);
            powerdame = 0;
            HP = GameHelper.Randomvalue(1000, 1500);
            atkspeed = GameHelper.Randomvalue(10, 30);
        }
    }
}
