using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblAutoreporttime
    {
        public UnitworkccsTblAutoreporttime()
        {
            UnitworkccsTblAutoreportsetting = new HashSet<UnitworkccsTblAutoreportsetting>();
        }

        public int AutoReportTimeId { get; set; }
        public string AutoReportTime { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<UnitworkccsTblAutoreportsetting> UnitworkccsTblAutoreportsetting { get; set; }
    }
}
