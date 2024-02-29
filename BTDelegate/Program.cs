using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTDelegate
{
    public delegate void CreateItem(int count);
    public delegate void Updatelv(int index);
    public delegate void UpdateRarity(int index1, int index2);
    public delegate void CreateHero();
    public delegate void UseItem(Item item,Chracter hero);
    public delegate void UnequipItem(Item item, Chracter hero);
    public delegate void SellItem(Item item);
    public class Program
    {
        public static CreateItem Gacha;
        public static Updatelv UpdateItemlv;
        public static UpdateRarity UpdateRarityItem;
        public static CreateHero createhero;
        public static UseItem useitem;
        public static UnequipItem unuseitem;
        public static SellItem sellItem;

        public static ItemManager itemmanager = null;
        public static UIManager uimanager = null;
        public static CharacterManager heromanager = null;

        static void Main(string[] args)
        {
            itemmanager = new ItemManager();
            uimanager = new UIManager();
            heromanager = new CharacterManager();
            Start();
            Console.ReadKey();
        }

        public static void Start()
        {
            int input = uimanager.MainMenu();
            if (input == 1)
            {
                uimanager.Gacha();
            }
            if (input == 2)
            {
                uimanager.ShowAllItem(itemmanager.items,heromanager.hero);
            }
            if (input == 3)
            {
                heromanager.CreateHero();
            }
            if(input == 4)
            {
                uimanager.ShowHero(heromanager.hero);
            }
        }
    }
}
