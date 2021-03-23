using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblendcodes
    {
        public int EndCodeId { get; set; }
        public string EndCode { get; set; }
        public string EndCodeSdesc { get; set; }
        public string EndCodeLdesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
