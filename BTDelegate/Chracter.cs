using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Chracter
    {
        public CharacterType type;
        public int attack;
        public int powerdame;
        public int HP;
        public int atkspeed;
        public List<Item> itemuse;

        public Chracter(CharacterType Type,int atk,int power,int health,int AtkSpeed) 
        {
            this.type = Type;
            this.attack = atk;
            this.powerdame = power;
            this.HP = health;
            this.atkspeed = AtkSpeed;
        }
    }
}
