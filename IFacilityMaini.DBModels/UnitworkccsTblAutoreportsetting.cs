using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblAutoreportsetting
    {
        public UnitworkccsTblAutoreportsetting()
        {
            UnitworkccsTblAutoreportLog = new HashSet<UnitworkccsTblAutoreportLog>();
        }

        public int AutoReportId { get; set; }
        public int? ReportId { get; set; }
        public int? BasedOn { get; set; }
        public int? AutoReportTimeId { get; set; }
        public string ToMailList { get; set; }
        public string CcmailList { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public int? MachineId { get; set; }
        public DateTime? NextRunDate { get; set; }

        public virtual UnitworkccsTblAutoreporttime AutoReportTime { get; set; }
        public virtual UnitworkccsTblAutoreportbasedon BasedOnNavigation { get; set; }
        public virtual UnitworkccsTblplant Plant { get; set; }
        public virtual UnitworkccsTblReportmaster Report { get; set; }
        public virtual UnitworkccsTblshop Shop { get; set; }
        public virtual ICollection<UnitworkccsTblAutoreportLog> UnitworkccsTblAutoreportLog { get; set; }
    }
}
