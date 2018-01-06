using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class MediaFormat
    {
        public MediaFormat()
        {
            MediaCopy = new HashSet<MediaCopy>();
        }

        public string Id { get; set; }
        public string Format { get; set; }

        public ICollection<MediaCopy> MediaCopy { get; set; }
    }
}
