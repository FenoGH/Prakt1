using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_8_
{
    public class Maxnums
    {
        public static int MaxNum(out string nums, int y, int x)
        {
            int buf = 0;
            int max = 0;
            nums = "";
            Random rnd = new Random();
            if (x > 0)
            {
                for (int i = 0; i != x; i++)
                {
                    buf = rnd.Next(0, y);
                    nums = $"{buf}" + " ; " + nums;
                    if (buf > max)
                    {
                        max = buf;
                    }
                }
            }
            return max;
        }
    }
}
