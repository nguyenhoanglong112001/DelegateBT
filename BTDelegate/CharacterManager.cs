using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class CharacterManager
    {
        public Chracter hero = null;
        public Enemy Monster = null;
        
        public CharacterManager() 
        {
            Program.createhero = CreateHero;
            Program.useitem = UseItem;
            Program.unuseitem = UnequipItem;
            Program.createenemy = CreateEnemy;
        }
        public void CreateEnemy()
        {
            Monster = new Enemy((CharacterType)GameHelper.Randomvalue(0, 5), "Monster", hero);
            Console.WriteLine("Enemy create");
            Program.uimanager.ShowHero(Monster);
            Console.ReadKey();
            Program.Start();
        }
        public void CreateHero()
        {
            Console.WriteLine("Hero name: ");
            string name = Console.ReadLine();
            CharacterType type = (CharacterType)Program.uimanager.CharcterType();
            switch(type)
            {
                case CharacterType.Assasin:
                    {
                        hero = new Assasin(CharacterType.Assasin, name);
                        break;
                    }
                case CharacterType.Fighter:
                    {
                        hero = new Fighter(CharacterType.Fighter,name);
                        break;
                    }
                case CharacterType.Support:
                    {
                        hero = new Support(CharacterType.Support,name);
                        break;
                    }
                case CharacterType.Tank:
                    {
                        hero = new Tanker(CharacterType.Tank, name);
                        break;
                    }
                case CharacterType.Range:
                    {
                        hero = new Ranged(CharacterType.Range,name);
                        break;
                    }
            }
            Console.WriteLine("Create hero success");
            Console.ReadKey();
            Program.Start();
        }
        public bool FullItem(Chracter hero)
        {
            if (hero.itemuse == null)
            {
                hero.itemuse = new List<Item>();
            }
            else if (hero.itemuse.Count >= 4)
            {
                Console.WriteLine("Full slot item");
                return true;
            }
            return false;
        }
        public void UseItem(int index, int slot, Item item,Chracter hero)
        {
            if (FullItem(hero))
            {
                return;
            }
            if (hero.itemuse == null)
            {
                hero.itemuse = new List<Item>(4);
            }
            hero.itemuse.Insert(slot, item);
            Program.itemmanager.items[index] = null;
        }

        public void UnequipItem (int slot, Item item, Chracter hero)
        {
            if (hero.itemuse == null)
            {
                return;
            }
            hero.itemuse.RemoveAt(slot);
            Program.itemmanager.items.Add(item);
        }
    }
}
