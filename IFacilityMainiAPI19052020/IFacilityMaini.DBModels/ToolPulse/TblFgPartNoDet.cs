using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblFgPartNoDet
    {
        public int FgPartId { get; set; }
        public int? PartId { get; set; }
        public string PartCountMethod { get; set; }
        public int? OperationNo { get; set; }
        public string WorkOrderNo { get; set; }
        public string NoOfPartsPerCycle { get; set; }
        public int? IsClosed { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? OperatorId { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
