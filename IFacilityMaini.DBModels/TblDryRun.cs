using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblDryRun
    {
        public int DryRunId { get; set; }
        public int? MachineId { get; set; }
        public int? FgPartId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string CorrectedDate { get; set; }
        public int? PartCount { get; set; }
        public string Shift { get; set; }
    }
}
