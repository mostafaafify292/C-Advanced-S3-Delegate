using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced_S3_Delegate
{
    
    internal class BookFunction
    {
        public static string GetTitle(Book B)
        {
           return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string test = B.Authors is not null ? string.Join(",", B.Authors) : "NONE";
            return test;
            
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
        public static string GetISBN(Book B)
        {
            return B.ISBN;

        }
        public static string GetPublicationDate(Book B)
        {
            return B.PublicationDate.ToString();
        }

    }
}
