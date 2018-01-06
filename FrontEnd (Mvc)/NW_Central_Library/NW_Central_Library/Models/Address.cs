using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class Address
    {
        public Address()
        {
            AdultMemberAddress = new HashSet<AdultMemberAddress>();
        }

        public int Id { get; set; }
        public string AddrLn1 { get; set; }
        public string AddrLn2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public ICollection<AdultMemberAddress> AdultMemberAddress { get; set; }
    }
}
