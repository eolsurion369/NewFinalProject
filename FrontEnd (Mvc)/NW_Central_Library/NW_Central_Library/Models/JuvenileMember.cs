using System;
using System.Collections.Generic;

namespace NW_Central_Library.Models
{
    public partial class JuvenileMember
    {
        public int Id { get; set; }
        public int AdultId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidInit { get; set; }
        public string Suffix { get; set; }
        public DateTime Birthdate { get; set; }
        public string PrimaryPhone { get; set; }
        public string EmailAddress { get; set; }

        public AdultMember Adult { get; set; }
    }
}
