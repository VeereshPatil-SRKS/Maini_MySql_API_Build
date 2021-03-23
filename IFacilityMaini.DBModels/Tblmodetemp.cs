using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmodetemp
    {
        public int ModeId { get; set; }
        public int MachineId { get; set; }
        public string MacMode { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ColorCode { get; set; }
        public int IsCompleted { get; set; }
        public int? DurationInSec { get; set; }
        public int? LossCodeId { get; set; }
        public int? BreakdownId { get; set; }
        public string ModeType { get; set; }
        public int ModeTypeEnd { get; set; }
        public int StartIdle { get; set; }
        public DateTime? LossCodeEnteredTime { get; set; }
        public int? LossCodeEnteredBy { get; set; }
        public int? TabModeId { get; set; }
        public int IsInserted { get; set; }

        public virtual Tblbreakdown Breakdown { get; set; }
        public virtual Tbllossescodes LossCode { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
    }
}
