using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblBusinessDetails
    {
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessDesc { get; set; }
        public int? IsDeleted { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
