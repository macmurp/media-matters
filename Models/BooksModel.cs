using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace media_matters.Models
{

    public class Book
    {
        public string ISBN { get; set; }
        public string AuthorLast { get; set; }
        public string AuthorFirst { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string PublishDate { get; set; }
        public string Cover { get; set; }
        public string Notes { get; set; }
        public Book(string ISBN, string AuthorLast, string AuthorFirst, string Title, string Edition, string PublishDate, string Cover, string Notes)
        {
            //constructor
            this.ISBN = ISBN;
            this.AuthorLast = AuthorLast;
            this.AuthorFirst = AuthorFirst;
            this.Title = Title;
            this.Edition = Edition;
            this.PublishDate = PublishDate;
            this.Cover = Cover;
            this.Notes = Notes;

        }
    }
}
 