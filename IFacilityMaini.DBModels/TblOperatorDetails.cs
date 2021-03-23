using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblOperatorDetails
    {
        public int OpId { get; set; }
        public string OperatorName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string MachineIds { get; set; }
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
        public string ContactNo { get; set; }
        public int? CategoryId { get; set; }
        public string Shift { get; set; }
        public int? CellId { get; set; }
        public int? SubCellId { get; set; }
        public int? PlantId { get; set; }
        public int? BusinessId { get; set; }
        public string DirectOrIndirect { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoing { get; set; }
        public int? PhotoId { get; set; }
    }
}
