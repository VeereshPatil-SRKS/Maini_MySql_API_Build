using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblplannedbreak
    {
        public int BreakId { get; set; }
        public string BreakReason { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? BreakDuration { get; set; }
        public int? ShiftId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual TblshiftMstr Shift { get; set; }
    }
}
