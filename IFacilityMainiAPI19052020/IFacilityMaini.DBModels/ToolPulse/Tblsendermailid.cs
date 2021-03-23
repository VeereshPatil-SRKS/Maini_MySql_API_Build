using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblsendermailid
    {
        public int SeId { get; set; }
        public string PrimaryMailId { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public int AutoEmailType { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblemailreporttype AutoEmailTypeNavigation { get; set; }
    }
}
