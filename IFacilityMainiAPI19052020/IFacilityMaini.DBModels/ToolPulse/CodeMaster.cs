using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class CodeMaster
    {
        public int CodeId { get; set; }
        public int? Code { get; set; }
        public string Mcode { get; set; }
        public string CodeDescription { get; set; }
        public string CodeType { get; set; }
        public DateTime? InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
