using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Enemy : Chracter
    {
        public Enemy(CharacterType Type, string name,Chracter hero) : base((CharacterType)GameHelper.Randomvalue(0,5), name)
        {
            level = GameHelper.Randomvalue(1, hero.level + 5);
            if (type == CharacterType.Tank)
            {
                Tanker tank = new Tanker(CharacterType.Tank,name);
                SetAttribute(tank);
            }
            else if (type == CharacterType.Assasin)
            {
                Assasin assasin = new Assasin(CharacterType.Assasin,name);
                SetAttribute(assasin);
            }
            else if (type == CharacterType.Support)
            {
                Support support = new Support(CharacterType.Support,name);
            }
            else if (type == CharacterType.Range)
            {
                Ranged range = new Ranged(CharacterType.Range,name);
                SetAttribute(range);
            }
            else if (type == CharacterType.Fighter)
            {
                Fighter fighter = new Fighter(CharacterType.Fighter,name);
                SetAttribute(fighter);
            }
            itemuse = new List<Item>();
            for (int i = 0; i < 4;i++)
            {
                itemuse.Insert(i, Program.itemmanager.items[GameHelper.Randomvalue(0, Program.itemmanager.items.Count)]);
            }
        }

        public void SetAttribute(Chracter character)
        {
            attack = character.attack;
            powerdame = character.powerdame;
            HP = character.HP;
            atkspeed = character.atkspeed;
        }
    }
}
