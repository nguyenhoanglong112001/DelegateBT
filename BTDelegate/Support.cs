using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Support : Chracter
    {
        public Support(CharacterType Type, string name) : base(Type, name)
        {
            attack = GameHelper.Randomvalue(20, 50);
            powerdame = GameHelper.Randomvalue(70, 150);
            HP = GameHelper.Randomvalue(250, 500);
            atkspeed = GameHelper.Randomvalue(10, 30);
        }
    }
}
