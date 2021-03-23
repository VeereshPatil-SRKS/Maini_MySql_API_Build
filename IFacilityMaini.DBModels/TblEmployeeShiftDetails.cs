using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblEmployeeShiftDetails
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Shift { get; set; }
        public string MachineIds { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
