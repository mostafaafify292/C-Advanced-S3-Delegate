using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Advanced_S3_Delegate.Program;

namespace C_Advanced_S3_Delegate
{
    //public delegate bool NumDelegata<T>(T x);
    public class StringFunction
    {
        public static List<T> FindElement<T>(List<T> list, Predicate<T> numDelegata)
        {
         List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (numDelegata.Invoke(list[i]))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

    }
}
