using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblactivitylog
    {
        public int TrackId { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string IpAddress { get; set; }
        public string ClientSystemName { get; set; }
        public string CompleteModificationDetails { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int Idoperationlog { get; set; }
        public string OpTime { get; set; }
        public DateTime OpDate { get; set; }
        public DateTime OpDateTime { get; set; }
    }
}
