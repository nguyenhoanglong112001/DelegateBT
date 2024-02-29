using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class ItemManager
    {
        public List<Item> items = null;

        public ItemManager() 
        {
            items = new List<Item>();
            Program.Gacha = CreateItem;
            Program.UpdateItemlv = UpdatelevelItem;
            Program.UpdateRarityItem = UpdateRarity;
            Program.sellItem = SellItem;
        }

        public void CreateItem(int count)
        {
            for (int i=0;i< count;i++)
            {
                ItemType type = (ItemType)GameHelper.Randomvalue(0, 4);
                ItemRarity rarity;
                int rate = GameHelper.Randomvalue(0, 100);

                if (rate < 2)
                {
                    rarity = ItemRarity.Mystical;
                }
                else if (rate < 8)
                {
                    rarity = ItemRarity.Lengendary;
                }
                else if (rate < 25)
                {
                    rarity = ItemRarity.Epic;
                }
                else if (rate < 50)
                {
                    rarity = ItemRarity.Rare;
                }
                else // rate >= 50
                {
                    rarity = ItemRarity.Common;
                }
                int level = 1;
                Item item = new Item(type, rarity, level,GameConstant.priceitem[rarity]);
                items.Add(item);
                Program.uimanager.ShowItem(item);
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }
        public void UpdatelevelItem(int index)
        {
            items[index].level++;
        }
        public bool CheckUpdateRarity(Item item)
        {
            if (item.rarity == ItemRarity.Mystical)
            {
                return false;
            }
            return true;
        }
        public void UpdateRarity(int index1, int index2)
        {
            if (!CheckUpdateRarity(items[index1]))
            {
                Console.WriteLine("Item has highest raruty");
                Console.ReadKey();
                return;
            }
            if (items[index1].type != items[index2].type && items[index1].rarity != items[index2].rarity ) 
            {
                Console.WriteLine("Item do not have same type and rarity");
                Console.ReadKey();
                return;
            }
            int level;
            if (items[index1].level > items[index2].level)
            {
                level = items[index1].level;
            }
            else { level = items[index2].level; }
            Item item = new Item(items[index1].type, (ItemRarity)((int)items[index1].rarity + 1), level, GameConstant.priceitem[(ItemRarity)((int)items[index1].rarity + 1)]);
            items.RemoveAt(index1);
            items.RemoveAt(index2);
            items.Add(item);
        }

        public void SellItem(Item item)
        {
            items.Remove(item);
        }
    }
}
