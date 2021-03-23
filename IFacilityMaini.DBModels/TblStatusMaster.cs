using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblStatusMaster
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
