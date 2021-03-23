using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblworeport
    {
        public int WoreportId { get; set; }
        public int? MachineId { get; set; }
        public int? Hmiid { get; set; }
        public string OperatorName { get; set; }
        public string Shift { get; set; }
        public string CorrectedDate { get; set; }
        public string PartNo { get; set; }
        public string WorkOrderNo { get; set; }
        public string OpNo { get; set; }
        public int? TargetQty { get; set; }
        public int? DeliveredQty { get; set; }
        public int? IsPf { get; set; }
        public int? IsHold { get; set; }
        public decimal? CuttingTime { get; set; }
        public decimal? SettingTime { get; set; }
        public decimal? SelfInspection { get; set; }
        public decimal? Idle { get; set; }
        public decimal? Breakdown { get; set; }
        public string Type { get; set; }
        public decimal? NccuttingTimePerPart { get; set; }
        public decimal? TotalNccuttingTime { get; set; }
        public decimal? Woefficiency { get; set; }
        public int? RejectedQty { get; set; }
        public string RejectedReason { get; set; }
        public string Program { get; set; }
        public decimal? Mrweight { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int IsMultiWo { get; set; }
        public int? IsNormalWc { get; set; }
        public string HoldReason { get; set; }
        public decimal? MinorLoss { get; set; }
        public string SplitWo { get; set; }
        public decimal? Blue { get; set; }
        public decimal? ScrapQtyTime { get; set; }
        public decimal? ReWorkTime { get; set; }
        public decimal? SummationOfSctvsPp { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? BatchNo { get; set; }
    }
}
