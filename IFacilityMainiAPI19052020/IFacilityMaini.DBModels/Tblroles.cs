using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblroles
    {
        public Tblroles()
        {
            TblOperatorLoginDetails = new HashSet<TblOperatorLoginDetails>();
            Tblrolemodulelink = new HashSet<Tblrolemodulelink>();
            TblusersPrimaryRoleNavigation = new HashSet<Tblusers>();
            TblusersSecondaryRoleNavigation = new HashSet<Tblusers>();
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

        public virtual ICollection<TblOperatorLoginDetails> TblOperatorLoginDetails { get; set; }
        public virtual ICollection<Tblrolemodulelink> Tblrolemodulelink { get; set; }
        public virtual ICollection<Tblusers> TblusersPrimaryRoleNavigation { get; set; }
        public virtual ICollection<Tblusers> TblusersSecondaryRoleNavigation { get; set; }
    }
}
