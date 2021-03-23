using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblpartscountandcutting
    {
        public int Pcid { get; set; }
        public int MachineId { get; set; }
        public int PartCount { get; set; }
        public int CuttingTime { get; set; }
        public int TargetQuantity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Isdeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? PartsPerCyscleEnteredTime { get; set; }
        public int WoPartCount { get; set; }
        public string ShiftName { get; set; }
        public int? CuttingTimeInSec { get; set; }
        public int WoTargetQty { get; set; }
        public int? RejectionQty { get; set; }
        public int? ReworkQty { get; set; }
        public int? ActualQty { get; set; }
        public int? DryRunQty { get; set; }
        public int? OkQty { get; set; }
    }
}
