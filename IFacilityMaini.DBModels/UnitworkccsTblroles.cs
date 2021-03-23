using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblroles
    {
        public UnitworkccsTblroles()
        {
            UnitworkccsTbloperatorlogindetails = new HashSet<UnitworkccsTbloperatorlogindetails>();
            UnitworkccsTblrolemodulelink = new HashSet<UnitworkccsTblrolemodulelink>();
            UnitworkccsTblusersPrimaryRoleNavigation = new HashSet<UnitworkccsTblusers>();
            UnitworkccsTblusersSecondaryRoleNavigation = new HashSet<UnitworkccsTblusers>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDisplayName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string RoleDesc { get; set; }

        public virtual ICollection<UnitworkccsTbloperatorlogindetails> UnitworkccsTbloperatorlogindetails { get; set; }
        public virtual ICollection<UnitworkccsTblrolemodulelink> UnitworkccsTblrolemodulelink { get; set; }
        public virtual ICollection<UnitworkccsTblusers> UnitworkccsTblusersPrimaryRoleNavigation { get; set; }
        public virtual ICollection<UnitworkccsTblusers> UnitworkccsTblusersSecondaryRoleNavigation { get; set; }
    }
}
