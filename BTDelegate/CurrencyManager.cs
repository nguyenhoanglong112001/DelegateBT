using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class CurrencyManager
    {
        public static int currentgold { get; protected set; } = 0;

        public static void GoldIncrease(int bonus)
        {
            currentgold += bonus;
        }
        public int GoldtoUpdate(int level)
        {
            return 50*level;
        }

        public bool CheckGoldUpdate()
        {

        }
    }
}
