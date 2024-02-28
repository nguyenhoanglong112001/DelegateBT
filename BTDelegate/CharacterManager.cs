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
        
        public CharacterManager() 
        {
            Program.createhero = CreateHero;
            Program.useitem = UseItem;
            Program.unuseitem = UnequipItem;
        }
        public void CreateHero()
        {
            CharacterType type = (CharacterType)GameHelper.Randomvalue(0, 5);
            switch(type)
            {
                case CharacterType.Assasin:
                    {
                        int atk = GameHelper.Randomvalue(130, 150);
                        int PowerDame = GameHelper.Randomvalue(0, 25);
                        int HP = GameHelper.Randomvalue(300, 600);
                        int speed = GameHelper.Randomvalue(25, 40);
                        hero = new Chracter(CharacterType.Assasin,atk,PowerDame,HP,speed);
                        break;
                    }
                case CharacterType.Fighter:
                    {
                        int atk = GameHelper.Randomvalue(80,100);
                        int PowerDame = GameHelper.Randomvalue(0, 10);
                        int HP = GameHelper.Randomvalue(700,1000);
                        int speed = GameHelper.Randomvalue(10, 50);
                        hero = new Chracter(CharacterType.Fighter, atk, PowerDame, HP, speed);
                        break;
                    }
                case CharacterType.Support:
                    {
                        int atk = GameHelper.Randomvalue(20, 50);
                        int PowerDame = GameHelper.Randomvalue(70, 150);
                        int HP = GameHelper.Randomvalue(250, 500);
                        int speed = GameHelper.Randomvalue(10, 30);
                        hero = new Chracter(CharacterType.Support, atk, PowerDame, HP, speed);
                        break;
                    }
                case CharacterType.Tank:
                    {
                        int atk = GameHelper.Randomvalue(50, 80);
                        int PowerDame = 0;
                        int HP = GameHelper.Randomvalue(1000, 1500);
                        int speed = GameHelper.Randomvalue(10, 30);
                        hero = new Chracter(CharacterType.Tank, atk, PowerDame, HP, speed);
                        break;
                    }
                case CharacterType.Range:
                    {
                        int atk = GameHelper.Randomvalue(100, 120);
                        int PowerDame = 0;
                        int HP = GameHelper.Randomvalue(200, 500);
                        int speed = GameHelper.Randomvalue(50, 70);
                        hero = new Chracter(CharacterType.Range, atk, PowerDame, HP, speed);
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
            else if (hero.itemuse.Count >= 3)
            {
                Console.WriteLine("Full slot item");
                return true;
            }
            return false;
        }
        public void UseItem(Item item,Chracter hero)
        {
            if (FullItem(hero))
            {
                return;
            }
            if (hero.itemuse == null)
            {
                hero.itemuse = new List<Item>();
            }
            hero.itemuse.Add(item);
            Program.itemmanager.items.Remove(item);
        }

        public void UnequipItem (Item item, Chracter hero)
        {
            if (hero.itemuse == null)
            {
                return;
            }
            hero.itemuse.Remove(item);
            Program.itemmanager.items.Add(item);
        }
    }
}
