using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Configurationtblmachinesensor
    {
        public int Msid { get; set; }
        public int MachineId { get; set; }
        public int Sid { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string Ipaddress { get; set; }
        public int PortNo { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual ConfigurationTblsensorgroup S { get; set; }
    }
}
