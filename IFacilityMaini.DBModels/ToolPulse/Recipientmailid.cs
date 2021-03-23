using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Recipientmailid
    {
        public int ReId { get; set; }
        public string MailId { get; set; }
        public int AutoEmailType { get; set; }
        public string DisplayName { get; set; }
        public string RecipientType { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblemailreporttype AutoEmailTypeNavigation { get; set; }
    }
}
