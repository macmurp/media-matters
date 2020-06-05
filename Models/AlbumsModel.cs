using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace media_matters.Models
{
    public class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Cover { get; set; }
        public string Notes { get; set; }

        public Album(string Title, string Artist, string Cover, string Notes)
        {
            //constructor
            this.Title = Title;
            this.Artist = Artist;
            this.Cover = Cover;
            this.Notes = Notes;
        }
    }
    //tried creating within Model but struggled to call it, left what I attempted here just to show



    //public class Albums
    //{

    //    public List<Album> AlbumList = new List<Album>()
    //    {
    //        new Album("tobi lou and the Loop - EP", "tobi lou", "tobi lou and the loop.jpg", "The songs have a relaxing, chill trap style hip-hop beat and smooth rap.")
    //    };
    //}
}


