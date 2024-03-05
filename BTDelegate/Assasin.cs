using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Assasin : Chracter
    {
        public Assasin(CharacterType type,string name) : base(type,name)
        {
            attack = GameHelper.Randomvalue(130, 150);
            powerdame = GameHelper.Randomvalue(0, 25);
            HP = GameHelper.Randomvalue(300, 600);
            atkspeed = GameHelper.Randomvalue(25, 40);
        }
    }
}
