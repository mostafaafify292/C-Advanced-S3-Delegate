using System.Text.RegularExpressions;

namespace C_Advanced_S3_Delegate
{
    internal class Program
    {
        public delegate string Test(Book book);
        public static string ProcessBooks(Book book1,Test t)
        {
            return t.Invoke(book1);
        }
        public static string ProcessBooksWithProperBuild(Book book1, Func<Book, string> func)
        {
            return func.Invoke(book1);
        }
        static void Main(string[] args)
        {
            #region Assignment PART01 1-Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            //Book book = new Book("boook", "bookTitle", new string[] { "mostfa", "mohamed", "afify" }, new DateTime(2000, 9, 20), 23);
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(BookFunction.GetTitle(book));
            //Console.WriteLine(BookFunction.GetAuthors(book));
            // Console.WriteLine(BookFunction.GetPrice(book)); 
            #endregion
            #region Assignment        1.You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 
            #region a)	Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            //Book book = new Book("boookISPN", "bookTitle", new string[] { "mostfa", "mohamed", "afify" }, new DateTime(2000, 9, 20), 23);
            //Console.WriteLine(ProcessBooks(book, BookFunction.GetAuthors));




            #endregion
            #region b)	Use the Proper build in delegate. 
            //Console.WriteLine(ProcessBooksWithProperBuild(book, BookFunction.GetTitle)); 
            #endregion
            #region c)	Anonymous Method (GetISBN).
            //Func<Book, string> func1 = delegate (Book B)
            //{
            //    return B.ISBN;

            //};
            //Console.WriteLine(func1.Invoke(book));


            #endregion
            #region d)	Lambda Expression (GetPublicationDate).
            //Func<Book,string> func2 = (B) => B.PublicationDate.ToString();
            //Console.WriteLine(func2.Invoke(book));

            #endregion
            #region Public Class LibraryEngine
            //List<Book> book = new List<Book>()
            //{
            // new Book("boookISPN", "bookTitle", new string[] { "mostfa", "mohamed", "afify" }, new DateTime(2000, 9, 20), 23),
            // new Book("boook01ISPN", "bookTitle2", new string[] { "mostfa1", "mohamed1", "afify1" }, new DateTime(2000, 9, 21), 225)
            //};
            ////with Lambda Expression
            //LibraryEngine.ProcessBook(book, (Book b) => b.ISBN.ToString());
            ////with defult
            //LibraryEngine.ProcessBook(book, BookFunction.GetPrice); 
            #endregion
            #endregion
            #region Assignment PART02 2.We need to Implement the List methods from scratch with all overloads.
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region ●	Exist
            //Console.WriteLine(numbers.Exists(N => N == 11)); 
            #endregion
            #region ●	Find All
            //var Result = numbers.FindAll(n => n % 3 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region ●	Find
            //Console.WriteLine(numbers.Find(N => N % 2 == 0));

            #endregion
            #region ●	Find index
            //Console.WriteLine(numbers.FindIndex(N => N % 2 == 0));

            #endregion
            #region ●	Find Last
            //Console.WriteLine(numbers.FindLast(N => N % 3 == 0));
            #endregion
            #region ●	Find Last Index
            //Console.WriteLine(numbers.FindLastIndex(N => N % 3 ==0)); // ==9
            #endregion
            #region ●	Foreach
            //numbers.ForEach(N => { Console.WriteLine(N * 2);  });
            #endregion
            #region ●	TrueForAll
            //Console.WriteLine(numbers.TrueForAll(N => N % 1 == 0));
            #endregion

            #endregion





            #region Revision on session
            //List<int> evenNum = new List<int>();
            //List<int> ints = new List<int>();
            //ints = Enumerable.Range(1, 100).ToList();
            //evenNum = StringFunction.FindElement(ints, Functions.CheckEvenNum);
            //foreach (var item in evenNum)
            //{
            //    Console.Write($" {item} , ");
            //}
            //Console.WriteLine("\n___________________________________");
            //List<string> strings = new List<string>() { "mostafa", "mohamed ", "ali", "alaa", "afify" };
            //List<string> NamesMoreThan4 = new List<string>();
            //NamesMoreThan4 = StringFunction.FindElement(strings, Functions.CheckLength);
            //foreach (var item in NamesMoreThan4)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion
        }
    }
}
