using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblOperatorDetails
    {
        public int OpId { get; set; }
        public string OperatorName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? MachineId { get; set; }
        public int? RoleId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string OperatorMobileNo { get; set; }
        public string OperatorEmailId { get; set; }
        public string Grade { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
        public int? DepartmentId { get; set; }
        public int? OpNo { get; set; }
    }
}
