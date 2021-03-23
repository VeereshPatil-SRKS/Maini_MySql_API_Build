using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmodulehelper
    {
        public int Id { get; set; }
        public string ModuleId { get; set; }
        public int? RoleId { get; set; }
        public byte[] IsAll { get; set; }
        public byte[] IsAdded { get; set; }
        public byte[] IsEdited { get; set; }
        public byte[] IsRemoved { get; set; }
        public byte[] IsReadonly { get; set; }
        public byte[] IsHidden { get; set; }
        public short IsDeleted { get; set; }
    }
}
