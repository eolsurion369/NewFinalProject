using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class AdultMember
    {
        public AdultMember()
        {
            AdultMemberAddress = new HashSet<AdultMemberAddress>();
            CheckOut = new HashSet<CheckOut>();
            JuvenileMember = new HashSet<JuvenileMember>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidInit { get; set; }
        public string Suffix { get; set; }
        public DateTime Birthdate { get; set; }
        public string PrimaryPhone { get; set; }
        public string EmailAddress { get; set; }

        public string FullName => $"{LastName}, {FirstName} {MidInit}";

        public ICollection<AdultMemberAddress> AdultMemberAddress { get; set; }
        public ICollection<CheckOut> CheckOut { get; set; }
        public ICollection<JuvenileMember> JuvenileMember { get; set; }
    }
}
