using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Chracter
    {
        public string charatername;
        public CharacterType type;
        public int attack;
        public int powerdame;
        public int HP;
        public int atkspeed;
        public int level;
        public List<Item> itemuse;
        public bool Alive => HP > 0;

        public Chracter(CharacterType Type,string name) 
        {
            this.type = Type;
            charatername = name;
            level = 1;
        }
    }
}
