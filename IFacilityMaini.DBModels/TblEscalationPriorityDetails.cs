using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblEscalationPriorityDetails
    {
        public int Epid { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? CellId { get; set; }
        public string CellName { get; set; }
        public int? SubCellId { get; set; }
        public string SubCellName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? SmspriorityLevel { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
