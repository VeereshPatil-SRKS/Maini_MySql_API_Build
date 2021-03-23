using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblcustomer
    {
        public int Cid { get; set; }
        public string CustomerName { get; set; }
        public string CustomerShortName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int Landline1 { get; set; }
        public int? Landline2 { get; set; }
        public string EmailId1 { get; set; }
        public string EmailId2 { get; set; }
        public int? Fax { get; set; }
        public byte[] Logo { get; set; }
        public string Website { get; set; }
        public string Cpname { get; set; }
        public string Cpdesignation { get; set; }
        public string Cpdepartment { get; set; }
        public string CpemailId { get; set; }
        public int? CpmobileNo { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
