using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblIpAddress
    {
        public int IpAddressId { get; set; }
        public string HostName { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
