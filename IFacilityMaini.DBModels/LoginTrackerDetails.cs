using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class LoginTrackerDetails
    {
        public int LoginTrackerDetailsId { get; set; }
        public int? MachineId { get; set; }
        public int? OperatorId { get; set; }
        public int? CurrentFgpart { get; set; }
        public string CurrentTicketRaisedId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogoutDateTime { get; set; }
        public bool IsLoggedIn { get; set; }
        public DateTime? InsertedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string Shift { get; set; }
        public string CorrectedDate { get; set; }
    }
}
