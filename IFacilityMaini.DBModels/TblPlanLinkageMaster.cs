using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblPlanLinkageMaster
    {
        public int PlanLinkageId { get; set; }
        public int? PlantId { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? ShiftId { get; set; }
        public string ProductionOrder { get; set; }
        public string RoutingId { get; set; }
        public int? Operation { get; set; }
        public decimal? WorkOrderQty { get; set; }
        public int? WorkOrderCompletedQty { get; set; }
        public int? WorkOrderBalanceQty { get; set; }
        public string ResourceId { get; set; }
        public int? ScheduledQty { get; set; }
        public DateTime? PlannedStartTime { get; set; }
        public DateTime? PlannedEndTime { get; set; }
        public decimal? SetUpTime { get; set; }
        public DateTime? SapDateTimeStamp { get; set; }
        public string FgPartNo { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string LastUpdatedUse { get; set; }
        public int? NumUpdates { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string PartName { get; set; }
        public decimal? IdealCycleTime { get; set; }
        public int? TargetPerHr { get; set; }
        public string Unit { get; set; }
        public int? PpId { get; set; }
    }
}
