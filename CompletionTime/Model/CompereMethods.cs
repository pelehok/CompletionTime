using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletionTime.Model
{
    class CompereMethods
    {
        public int Diff(Job item1,Job item2)
        {
            int diff1 = item1.weight - item1.lenght;
            int diff2 = item2.weight - item2.lenght;
            if (diff1 == diff2)
            {
                if (item1.weight > item2.weight)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return diff2.CompareTo(diff1);
        }

        public int Ratio(Job item1, Job item2)
        {
            double ratio1 = (double)(item1.weight)/ (double)(item1.lenght);
            double ratio2 = (double)(item2.weight)/ (double)(item2.lenght);
            
            return ratio2.CompareTo(ratio1);
        }
    }
}
