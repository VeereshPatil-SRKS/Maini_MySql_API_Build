using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblControlPlan
    {
        public int CpId { get; set; }
        public int? PlantId { get; set; }
        public int? CellId { get; set; }
        public int? ChildPartNo { get; set; }
        public int? RoutingNo { get; set; }
        public string FgDesc { get; set; }
        public string ControlPlanNo { get; set; }
        public decimal? RevisionNo { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
        public int? MachineId { get; set; }
    }
}
