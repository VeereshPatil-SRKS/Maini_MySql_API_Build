using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class ProgramTemp
    {
        public int ProgramId { get; set; }
        public string ProgramData { get; set; }
        public DateTime ProgramDateTime { get; set; }
        public int? MachineId { get; set; }
    }
}
