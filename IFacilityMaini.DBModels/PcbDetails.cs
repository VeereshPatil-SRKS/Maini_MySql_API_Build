using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class PcbDetails
    {
        public int Pcbid { get; set; }
        public int? Pcbno { get; set; }
        public string Pcbipaddress { get; set; }
        public string Pcbmacaddress { get; set; }
        public int? MachineId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
