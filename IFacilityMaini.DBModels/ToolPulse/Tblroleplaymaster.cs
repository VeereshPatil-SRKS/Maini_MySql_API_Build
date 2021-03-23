using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblroleplaymaster
    {
        public int RolePlayId { get; set; }
        public int ModuleId { get; set; }
        public bool IsAll { get; set; }
        public bool IsAdded { get; set; }
        public bool IsEdited { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsHidden { get; set; }
        public bool IsReadOnly { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
        public int RoleId { get; set; }

        public virtual Tblmodulemaster Module { get; set; }
    }
}
