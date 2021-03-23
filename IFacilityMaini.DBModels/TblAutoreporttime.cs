using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAutoreporttime
    {
        public TblAutoreporttime()
        {
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
        }

        public int AutoReportTimeId { get; set; }
        public string AutoReportTime { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
    }
}
