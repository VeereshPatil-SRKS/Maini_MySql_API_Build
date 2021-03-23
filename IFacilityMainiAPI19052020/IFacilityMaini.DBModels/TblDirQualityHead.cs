using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblDirQualityHead
    {
        public int DirQhId { get; set; }
        public string PartDescription { get; set; }
        public string WorkOrderNumber { get; set; }
        public int? OperatorId { get; set; }
        public string EmployeeNo { get; set; }
        public string ReworkOrReject { get; set; }
        public string OpenTracker { get; set; }
        public string TrackerNo { get; set; }
        public string RouteCause { get; set; }
        public string Responsibility { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string Remarks { get; set; }
        public string Shift { get; set; }
        public string Action { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? MachineId { get; set; }
    }
}
