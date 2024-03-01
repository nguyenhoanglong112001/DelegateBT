using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Enemy : Chracter
    {
        public Enemy(CharacterType Type, int atk, int power, int health, int AtkSpeed,int level) : base(Type, atk, power, health, AtkSpeed)
        {
            this.level = level;
        }
    }
}
