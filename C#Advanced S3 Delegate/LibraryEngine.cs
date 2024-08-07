using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced_S3_Delegate
{
    internal class LibraryEngine
    {
        public static void ProcessBook(List<Book> list ,Func<Book,string> func )
        {
            foreach (var item in list)
            {
                Console.WriteLine(func(item));
            }

        }
    }
}
