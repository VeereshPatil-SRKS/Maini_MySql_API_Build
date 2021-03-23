using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmachineallocation
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? MachineId { get; set; }
        public int? ShiftId { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual TblshiftMstr Shift { get; set; }
        public virtual Tblusers User { get; set; }
    }
}
