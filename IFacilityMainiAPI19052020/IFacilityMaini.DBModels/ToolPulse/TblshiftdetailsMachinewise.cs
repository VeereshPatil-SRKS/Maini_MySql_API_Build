using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblshiftdetailsMachinewise
    {
        public int ShiftDetailsMacId { get; set; }
        public int MachineId { get; set; }
        public string ShiftName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsDeleted { get; set; }
        public string InsertedOn { get; set; }
        public int? InsertedBy { get; set; }
        public int? ShiftDetailsId { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
