using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsPcbdaqinTbl
    {
        public int Daqinid { get; set; }
        public string Pcbipaddress { get; set; }
        public int ParamPin { get; set; }
        public int? ParamValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
