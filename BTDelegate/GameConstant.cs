using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public enum ItemType
    {
        Sword,
        Amor,
        Staff,
        Bow
    }

    public enum ItemRarity
    {
        Common,
        Rare,
        Epic,
        Lengendary,
        Mystical
    }

    public enum CharacterType
    {
        Tank,
        Fighter,
        Assasin,
        Support,
        Range
    }
    public class GameConstant
    {
        public static Dictionary<ItemRarity, int> priceitem = new Dictionary<ItemRarity, int>
        {
            {ItemRarity.Common,100},
            {ItemRarity.Rare,150 },
            {ItemRarity.Epic,250 },
            {ItemRarity.Lengendary, 400 },
            {ItemRarity.Mystical,600 }
        };
    }
}
