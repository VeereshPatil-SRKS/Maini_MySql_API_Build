using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblemailreporttype
    {
        public Tblemailreporttype()
        {
            Recipientmailid = new HashSet<Recipientmailid>();
            Tblsendermailid = new HashSet<Tblsendermailid>();
        }

        public int Ertid { get; set; }
        public string ReportType { get; set; }
        public string ReportDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Recipientmailid> Recipientmailid { get; set; }
        public virtual ICollection<Tblsendermailid> Tblsendermailid { get; set; }
    }
}
