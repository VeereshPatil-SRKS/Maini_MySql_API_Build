using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblshiftMstr
    {
        public TblshiftMstr()
        {
            Tblmachineallocation = new HashSet<Tblmachineallocation>();
            Tblplannedbreak = new HashSet<Tblplannedbreak>();
        }

        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Duration { get; set; }

        public virtual ICollection<Tblmachineallocation> Tblmachineallocation { get; set; }
        public virtual ICollection<Tblplannedbreak> Tblplannedbreak { get; set; }
    }
}
