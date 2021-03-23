using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class WimerasysDir
    {
        public int Id { get; set; }
        public string Plant { get; set; }
        public string Cell { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public string Machine { get; set; }
        public string WorkOrderNumber { get; set; }
        public string Operator { get; set; }
        public string CardNumber { get; set; }
        public DateTime? Date { get; set; }
        public string Shift { get; set; }
        public int? Quantity { get; set; }
        public string DefectCode { get; set; }
        public string DefectDescription { get; set; }
        public string ScrapOrRework { get; set; }
        public string OpenTracker { get; set; }
        public string TrackerNumber { get; set; }
        public string RootCause { get; set; }
        public string Action { get; set; }
        public string Responsibility { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? CompeletedDate { get; set; }
        public string QrCode { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int? RejectId { get; set; }
        public int? ReworkId { get; set; }
        public int? ScrapParts { get; set; }
        public int? ReworkParts { get; set; }
        public int? OkParts { get; set; }
        public string RejectOrRework { get; set; }
        public string SubCell { get; set; }
        public string Category { get; set; }
        public string StorageLocation { get; set; }
        public DateTime? CheckDirQhdate { get; set; }
        public string CheckDirQhverify { get; set; }
        public string CheckDirRiverify { get; set; }
        public DateTime? CheckDirRidate { get; set; }
        public string ApproveDirRiverify { get; set; }
        public DateTime? ApproveDirRidate { get; set; }
        public string QtyHeadVerification { get; set; }
        public DateTime? QtyHeadVerificationDate { get; set; }
        public string ProductionHeadVerification { get; set; }
        public DateTime? ProductionHeadVerificationDate { get; set; }
        public string CheckDirHodverify { get; set; }
        public DateTime? CheckDirHoddate { get; set; }
        public string Riverification { get; set; }
        public DateTime? RiverificationDate { get; set; }
    }
}
