using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<T1, T2>

    {
        private T1 item1;
        private T2 item2;
        public void ReadFirstTuple()
        {
            string[] input = Console.ReadLine().Split();
            item1 = (T1)Convert.ChangeType(input[0], typeof(T1));
            item2 = (T2)Convert.ChangeType(input[1], typeof(T2));
        }
        public void ReadSecondTuple()
        {
            string[] input = Console.ReadLine().Split();
            item1 = (T1)Convert.ChangeType(input[0], typeof(T1));
            item2 = (T2)Convert.ChangeType(input[1], typeof(T2));
        }
        
    }
}
