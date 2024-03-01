using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class ExpManager
    {
        public int currentexp = 0;

        public int explevelup(int level)
        {
            return 100 * level;
        }

        public bool Checkexp(int level)
        {
            if (currentexp == explevelup(level))
            {
                return true;
            }
            return false;
        }
    }
}
