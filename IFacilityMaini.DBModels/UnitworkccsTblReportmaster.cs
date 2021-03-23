using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblReportmaster
    {
        public UnitworkccsTblReportmaster()
        {
            UnitworkccsTblAutoreportsetting = new HashSet<UnitworkccsTblAutoreportsetting>();
        }

        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string ReportDispName { get; set; }
        public string ReportTemplatePath { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<UnitworkccsTblAutoreportsetting> UnitworkccsTblAutoreportsetting { get; set; }
    }
}
