using System;
using System.Collections.Generic;

namespace NW_Central_Library.LibraryModels
{
    public partial class LibraryLogin
    {
        public string UserId { get; set; }
        public string UserPw { get; set; }
        public DateTime PwupdateDate { get; set; }
        public DateTime PwexpirationDate { get; set; }
        public bool? AccountLockout { get; set; }
    }
}
