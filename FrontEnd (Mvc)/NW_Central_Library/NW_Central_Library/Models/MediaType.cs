using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class MediaType
    {
        public MediaType()
        {
            MediaCopy = new HashSet<MediaCopy>();
            MediaTypeGenre = new HashSet<MediaTypeGenre>();
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public ICollection<MediaCopy> MediaCopy { get; set; }
        public ICollection<MediaTypeGenre> MediaTypeGenre { get; set; }
    }
}
