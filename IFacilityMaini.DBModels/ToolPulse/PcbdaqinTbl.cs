using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class PcbdaqinTbl
    {
        public int Daqinid { get; set; }
        public string Pcbipaddress { get; set; }
        public int ParamPin { get; set; }
        public int? ParamValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
