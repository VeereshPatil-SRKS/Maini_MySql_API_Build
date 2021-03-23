using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblVendor
    {
        public int VendorId { get; set; }
        public string Vendor { get; set; }
        public string VendorName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
