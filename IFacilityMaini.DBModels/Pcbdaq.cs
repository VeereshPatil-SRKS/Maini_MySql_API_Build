using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Pcbdaq
    {
        public int Pcbdaqid { get; set; }
        public string Pcbipaddress { get; set; }
        public int PinNumber { get; set; }
        public int? ParamValue { get; set; }
        public DateTime? PcbdateTime { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
