using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class MediaCopy
    {
        public MediaCopy()
        {
            CheckOut = new HashSet<CheckOut>();
        }

        public int Id { get; set; }
        public int MediaId { get; set; }
        public string MediaTypeId { get; set; }
        public string MediaFormatId { get; set; }
        public int CopyNumber { get; set; }

        public Media Media { get; set; }
        public MediaFormat MediaFormat { get; set; }
        public MediaType MediaType { get; set; }
        public ICollection<CheckOut> CheckOut { get; set; }
    }
}
