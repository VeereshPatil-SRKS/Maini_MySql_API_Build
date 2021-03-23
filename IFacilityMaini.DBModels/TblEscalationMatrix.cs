using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblEscalationMatrix
    {
        public long EscalationId { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? OpNo { get; set; }
        public string ContactNo { get; set; }
        public string Cell { get; set; }
        public string CellId { get; set; }
        public string SubCell { get; set; }
        public string SubCellId { get; set; }
        public string Role { get; set; }
        public int? RoleId { get; set; }
        public string CategoryId { get; set; }
        public string Category { get; set; }
        public string Shift { get; set; }
        public int? ShiftId { get; set; }
        public int? MachineId { get; set; }
        public string MachineName { get; set; }
        public string SmsPriority { get; set; }
        public int? TimeToBeTriggered { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? PlantId { get; set; }
        public string PlantCode { get; set; }
    }
}
