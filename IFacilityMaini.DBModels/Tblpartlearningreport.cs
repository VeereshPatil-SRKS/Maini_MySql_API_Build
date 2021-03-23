using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblpartlearningreport
    {
        public int PlreportId { get; set; }
        public int? MachineId { get; set; }
        public int? Hmiid { get; set; }
        public string CorrectedDate { get; set; }
        public string WorkOrderNo { get; set; }
        public string Fgcode { get; set; }
        public string OpNo { get; set; }
        public int? TargetQty { get; set; }
        public int? TotalQty { get; set; }
        public int? YieldQty { get; set; }
        public int? ScrapQty { get; set; }
        public decimal? SettingTime { get; set; }
        public decimal? Idle { get; set; }
        public decimal? MinorLoss { get; set; }
        public decimal? PowerOff { get; set; }
        public decimal? Breakdown { get; set; }
        public decimal? TotalNccuttingTime { get; set; }
        public decimal? AvgCuttingTime { get; set; }
        public decimal? StdCycleTime { get; set; }
        public decimal? TotalStdCycleTime { get; set; }
        public decimal? Woefficiency { get; set; }
        public decimal? StdMinorLoss { get; set; }
        public decimal? TotalStdMinorLoss { get; set; }
        public DateTime? InsertedOn { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
