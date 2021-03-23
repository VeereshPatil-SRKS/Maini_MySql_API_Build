using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblOperatorDashboard
    {
        public int OperatorDashboardId { get; set; }
        public int MachineId { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int SlNo { get; set; }
        public string MessageCode { get; set; }
        public string MessageDescription { get; set; }
        public DateTime MessageStartTime { get; set; }
        public DateTime? MessageEndTime { get; set; }
        public int? TotalDurationinMin { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
    }
}
