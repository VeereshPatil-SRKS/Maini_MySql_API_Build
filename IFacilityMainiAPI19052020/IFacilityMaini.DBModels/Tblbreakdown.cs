using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblbreakdown
    {
        public Tblbreakdown()
        {
            Tbllivemode = new HashSet<Tbllivemode>();
            Tblmodetemp = new HashSet<Tblmodetemp>();
        }

        public int BreakdownId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? BreakDownCode { get; set; }
        public int MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public string MessageDesc { get; set; }
        public string MessageCode { get; set; }
        public int? DoneWithRow { get; set; }

        public virtual Tbllossescodes BreakDownCodeNavigation { get; set; }
        public virtual ICollection<Tbllivemode> Tbllivemode { get; set; }
        public virtual ICollection<Tblmodetemp> Tblmodetemp { get; set; }
    }
}
