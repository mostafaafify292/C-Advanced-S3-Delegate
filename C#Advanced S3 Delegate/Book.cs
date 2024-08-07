using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced_S3_Delegate
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            string athorTest = Authors is not null ? string.Join(",", Authors) : "None";
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"ISBN : {ISBN} , Title : {Title} , Authors : {string.Join(",", Authors  )} ");
            //sb.Append(string.Join(",", Authors )); 
            // sb.AppendJoin(",", Authors);
            //return sb.ToString();



            return $"ISBN = {ISBN} , Title = {Title} , Authors = {athorTest} , PublicationDate = {PublicationDate} , Price = {Price} ";
        }


    }
}
