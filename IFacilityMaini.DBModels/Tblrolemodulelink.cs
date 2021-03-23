using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblrolemodulelink
    {
        public int Mrmlid { get; set; }
        public int? RoleId { get; set; }
        public int? ModuleId { get; set; }
        public short IsVisible { get; set; }
        public short EnableAdd { get; set; }
        public short EnableEdit { get; set; }
        public short EnableDelete { get; set; }
        public short EnableReadOnly { get; set; }
        public short EnableReport { get; set; }
        public short IsSuperAdmin { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }

        public virtual Tblusers InsertedByNavigation { get; set; }
        public virtual Tblmodules Module { get; set; }
        public virtual Tblroles ModuleNavigation { get; set; }
    }
}
