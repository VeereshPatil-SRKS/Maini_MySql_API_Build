using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmailids
    {
        public int MailIdsId { get; set; }
        public string EmployeeName { get; set; }
        public string EmailId { get; set; }
        public string EmployeeContactNum { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeDesignation { get; set; }
    }
}
