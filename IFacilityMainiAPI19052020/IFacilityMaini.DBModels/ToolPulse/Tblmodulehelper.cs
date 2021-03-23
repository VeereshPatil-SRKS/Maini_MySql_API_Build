using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmodulehelper
    {
        public int Id { get; set; }
        public string ModuleId { get; set; }
        public int? RoleId { get; set; }
        public bool? IsAll { get; set; }
        public bool? IsAdded { get; set; }
        public bool? IsEdited { get; set; }
        public bool? IsRemoved { get; set; }
        public bool? IsReadonly { get; set; }
        public bool? IsHidden { get; set; }
        public short IsDeleted { get; set; }
    }
}
