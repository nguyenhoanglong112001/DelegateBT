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
        
        public Item(ItemType type,ItemRarity rarity, int level)
        {
            this.type = type;
            this.rarity = rarity;
            this.level = level;
        }
    }
}
