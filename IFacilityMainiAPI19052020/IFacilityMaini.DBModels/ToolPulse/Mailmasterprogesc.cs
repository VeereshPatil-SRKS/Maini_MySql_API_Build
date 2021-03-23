using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Mailmasterprogesc
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public int Toadd { get; set; }
        public int Ccadd { get; set; }
        public int IsDeleted { get; set; }
        public int Bccadd { get; set; }
    }
}
