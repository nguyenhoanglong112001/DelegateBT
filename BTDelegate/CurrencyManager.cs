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
        public static int GoldtoUpdate(int level)
        {
            return 50*level;
        }

        public static bool CheckGoldUpdate(int level)
        {
            if (currentgold <= GoldtoUpdate(level))
            {
                return false;
            }
            return true;
        }
    }
}
