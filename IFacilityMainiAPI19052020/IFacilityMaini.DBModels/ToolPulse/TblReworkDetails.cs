using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblReworkDetails
    {
        public int ReworkId { get; set; }
        public int? FgPartId { get; set; }
        public int? DefectCodeId { get; set; }
        public int? DefectQty { get; set; }
        public int? MachineId { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
