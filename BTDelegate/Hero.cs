using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Hero : Chracter
    {
        public Hero(CharacterType Type, int atk, int power, int health, int AtkSpeed) : base(Type, atk, power, health, AtkSpeed)
        {
            level = 1;
        }
    }
}
