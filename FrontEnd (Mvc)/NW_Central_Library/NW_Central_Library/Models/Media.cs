using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class Media
    {
        public Media()
        {
            MediaCopy = new HashSet<MediaCopy>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Genre GenreNavigation { get; set; }
        public ICollection<MediaCopy> MediaCopy { get; set; }
    }
}
