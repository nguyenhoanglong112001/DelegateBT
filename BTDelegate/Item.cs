using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class Item
    {
        public ItemType type;
        public ItemRarity rarity;
        public int level;
        public int price;
        
        public Item(ItemType type,ItemRarity rarity, int level,int price)
        {
            this.type = type;
            this.rarity = rarity;
            this.level = level;
            this.price = price;
        }
    }
}
