using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsLogintrackerdetails
    {
        public int LoginTrackerDetailsId { get; set; }
        public int? MachineId { get; set; }
        public int? OperatorId { get; set; }
        public int? CurrentFgpart { get; set; }
        public string CurrentTicketRaisedId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogoutDateTime { get; set; }
        public byte? IsLoggedIn { get; set; }
        public DateTime? InsertedOn { get; set; }
        public byte? IsDeleted { get; set; }
        public string Shift { get; set; }
        public string CorrectedDate { get; set; }
    }
}
