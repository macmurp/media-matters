using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace media_matters.Models
{
    public class Videogame
    {
        public string Title { get; set; }
        public string System { get; set; }
        public string Cover { get; set; }
        public string Genre { get; set; }
        public string Notes { get; set; }
        public Videogame(string Title, string System, string Cover, string Genre, string Notes)
        {
            this.Title = Title;
            this.Cover = Cover;
            this.System = System;
            this.Genre = Genre;
            this.Notes = Notes;
        }
    }
}
