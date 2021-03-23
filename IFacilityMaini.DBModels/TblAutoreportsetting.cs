using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAutoreportsetting
    {
        public TblAutoreportsetting()
        {
            TblAutoreportLog = new HashSet<TblAutoreportLog>();
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

        public virtual TblAutoreporttime AutoReportTime { get; set; }
        public virtual TblAutoreportbasedon BasedOnNavigation { get; set; }
        public virtual Tblcell Cell { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual TblReportmaster Report { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual ICollection<TblAutoreportLog> TblAutoreportLog { get; set; }
    }
}
