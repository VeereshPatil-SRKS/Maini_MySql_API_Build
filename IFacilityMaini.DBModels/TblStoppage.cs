using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblStoppage
    {
        public int StoppagesId { get; set; }
        public int? CategoryId { get; set; }
        public int? AlramNo { get; set; }
        public string AlramDesc { get; set; }
        public int? SourceId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
