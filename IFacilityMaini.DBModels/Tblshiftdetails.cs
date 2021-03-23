using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblshiftdetails
    {
        public int ShiftDetailsId { get; set; }
        public string ShiftDetailsName { get; set; }
        public string ShiftDetailsDesc { get; set; }
        public int? ShiftMethodId { get; set; }
        public TimeSpan? ShiftStartTime { get; set; }
        public TimeSpan? ShiftEndTime { get; set; }
        public int? Duration { get; set; }
        public int? NextDay { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsShiftDetailsEdited { get; set; }
        public DateTime? ShiftDetailsEditedDate { get; set; }
        public int? IsGshift { get; set; }

        public virtual Tblshiftmethod ShiftMethod { get; set; }
    }
}
