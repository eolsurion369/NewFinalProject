using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Media = new HashSet<Media>();
            MediaTypeGenre = new HashSet<MediaTypeGenre>();
        }

        public string Id { get; set; }
        public string Genre1 { get; set; }

        public ICollection<Media> Media { get; set; }
        public ICollection<MediaTypeGenre> MediaTypeGenre { get; set; }
    }
}
