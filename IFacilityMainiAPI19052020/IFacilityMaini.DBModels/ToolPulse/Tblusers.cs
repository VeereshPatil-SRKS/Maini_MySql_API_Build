using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblusers
    {
        public Tblusers()
        {
            Tblmachineallocation = new HashSet<Tblmachineallocation>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PrimaryRole { get; set; }
        public int SecondaryRole { get; set; }
        public string DisplayName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? MachineId { get; set; }
        public int? PlantId { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual Tblroles PrimaryRoleNavigation { get; set; }
        public virtual Tblroles SecondaryRoleNavigation { get; set; }
        public virtual ICollection<Tblmachineallocation> Tblmachineallocation { get; set; }
    }
}
