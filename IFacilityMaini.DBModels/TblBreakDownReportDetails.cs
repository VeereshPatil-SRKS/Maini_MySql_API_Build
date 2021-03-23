using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblBreakDownReportDetails
    {
        public int Id { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? OperatingTime { get; set; }
        public decimal? DryRunTime { get; set; }
        public decimal? SetUpTime { get; set; }
        public decimal? LoadUnloadTime { get; set; }
        public decimal? LossOrIdleTime { get; set; }
        public decimal? BreakdownTime { get; set; }
        public decimal? PowerOffOrDataLossTime { get; set; }
        public decimal? Utilization { get; set; }
        public decimal? ElectricalMaintenance { get; set; }
        public decimal? MechanicalMaintenance { get; set; }
        public decimal? Production { get; set; }
        public decimal? HumanResource { get; set; }
        public decimal? Quality { get; set; }
        public decimal? ToolingStoppage { get; set; }
        public decimal? Planning { get; set; }
        public decimal? ElectricalMaintenance1 { get; set; }
        public decimal? MechanicalMaintenance1 { get; set; }
        public decimal? Production1 { get; set; }
        public decimal? HumanResource1 { get; set; }
        public decimal? Quality1 { get; set; }
        public decimal? ToolingStoppage1 { get; set; }
        public decimal? Planning1 { get; set; }
        public DateTime? IsCreatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
