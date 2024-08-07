using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced_S3_Delegate
{
    internal class Functions
    {
        public static bool CheckOddNum(int x)
        {
            return x % 2 == 1;
        }
        public static bool CheckEvenNum(int x)
        { 
          return x % 2 == 0;
        }
        public static bool CheckLength (string s)
        {
            return s.Length > 4;
        }

    }
}
