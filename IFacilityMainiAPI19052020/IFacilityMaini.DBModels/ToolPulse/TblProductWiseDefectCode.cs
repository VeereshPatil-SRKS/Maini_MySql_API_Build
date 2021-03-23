using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblProductWiseDefectCode
    {
        public int ProductWiseDefectCodeId { get; set; }
        public int? Trim { get; set; }
        public int? PlantId { get; set; }
        public int? PartId { get; set; }
        public int? DefectCodeId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
