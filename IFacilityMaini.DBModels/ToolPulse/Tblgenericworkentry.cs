using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblgenericworkentry
    {
        public int GwentryId { get; set; }
        public int GwcodeId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string CorrectedDate { get; set; }
        public int MachineId { get; set; }
        public string Shift { get; set; }
        public string GwcodeDesc { get; set; }
        public string Gwcode { get; set; }
        public int DoneWithRow { get; set; }

        public virtual Tblgenericworkcodes GwcodeNavigation { get; set; }
    }
}
