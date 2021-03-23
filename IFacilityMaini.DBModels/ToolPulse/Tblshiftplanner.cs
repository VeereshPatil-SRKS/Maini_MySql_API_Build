using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblshiftplanner
    {
        public int ShiftPlannerId { get; set; }
        public string ShiftPlannerName { get; set; }
        public string ShiftPlannerDesc { get; set; }
        public int ShiftMethodId { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public int? MachineId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? IsPlanStopped { get; set; }
        public DateTime? PlanStoppedDate { get; set; }
        public int? IsPlanRemoved { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
    }
}
