using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class AdultMemberAddress
    {
        public int MemberId { get; set; }
        public int AddressId { get; set; }

        public Address Address { get; set; }
        public AdultMember Member { get; set; }
    }
}
