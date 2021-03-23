using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmodulemaster
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] IsSuperAdmin { get; set; }
        public byte[] EnableReport { get; set; }
        public byte[] EnableAdd { get; set; }
        public byte[] EnableEdit { get; set; }
        public byte[] EnableDelete { get; set; }
        public int? RoleId { get; set; }
    }
}
