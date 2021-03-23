using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class UserMaster
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? ModifiedBy { get; set; }
        public string EmailId { get; set; }
        public int IsDeleted { get; set; }
        public int RoleId { get; set; }
    }
}
