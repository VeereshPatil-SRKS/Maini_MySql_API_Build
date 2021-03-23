using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblFgPartNoDet
    {
        public TblFgPartNoDet()
        {
            TblProdManMachine = new HashSet<TblProdManMachine>();
        }

        public int FgPartId { get; set; }
        public int? PartId { get; set; }
        public string PartCountMethod { get; set; }
        public int? OperationNo { get; set; }
        public string WorkOrderNo { get; set; }
        public string NoOfPartsPerCycle { get; set; }
        public int? IsClosed { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? OperatorId { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? PlanLinkageId { get; set; }
        public int? ActaulValue { get; set; }
        public int? TargetQty { get; set; }
        public double? Availibility { get; set; }
        public double? Performance { get; set; }
        public double? Quality { get; set; }
        public double? Oee { get; set; }
        public string FgPartNo { get; set; }
        public decimal? IdealCycleTime { get; set; }
        public string Unit { get; set; }
        public int? ScheduledQty { get; set; }
        public DateTime? PlannedStartTime { get; set; }
        public DateTime? PlannedEndTime { get; set; }
        public string RoutingId { get; set; }
        public string PartName { get; set; }
        public int? WorkOrderCompletedQty { get; set; }
        public int? RunningBalance { get; set; }

        public virtual ICollection<TblProdManMachine> TblProdManMachine { get; set; }
    }
}
