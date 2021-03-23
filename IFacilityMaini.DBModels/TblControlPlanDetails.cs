using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblControlPlanDetails
    {
        public int ControlPlanDetId { get; set; }
        public string CustomerRefCpNo { get; set; }
        public string OperationNo { get; set; }
        public string BallunNo { get; set; }
        public int? ProcessId { get; set; }
        public string SpecialCharacterClass { get; set; }
        public int? Dimension { get; set; }
        public int? ProductId { get; set; }
        public decimal? MinToleranace { get; set; }
        public decimal? MaxTolerance { get; set; }
        public string RecordingMethod { get; set; }
        public string Responsibility { get; set; }
        public string ReactionPlan { get; set; }
        public string Frequency { get; set; }
        public TimeSpan? Time { get; set; }
        public string EvaluationMethod { get; set; }
        public decimal? RevisionNo { get; set; }
        public string OperationalDescription { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PartNo { get; set; }
        public int? ControlPlanId { get; set; }
    }
}
