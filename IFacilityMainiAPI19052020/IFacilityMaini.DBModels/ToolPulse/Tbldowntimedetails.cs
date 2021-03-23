using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tbldowntimedetails
    {
        public int DtId { get; set; }
        public int DtcategoryId { get; set; }
        public string Dtreason { get; set; }
        public string Dtdesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tbldowntimecategory Dtcategory { get; set; }
    }
}
