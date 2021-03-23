using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblNoOfAxis
    {
        public int NoOfAxisId { get; set; }
        public int? NoOfAxis { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
