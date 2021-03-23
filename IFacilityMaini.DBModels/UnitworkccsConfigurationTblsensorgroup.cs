using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsConfigurationTblsensorgroup
    {
        public UnitworkccsConfigurationTblsensorgroup()
        {
            UnitworkccsConfigurationtblmachinesensor = new HashSet<UnitworkccsConfigurationtblmachinesensor>();
            UnitworkccsConfigurationtblsensormaster = new HashSet<UnitworkccsConfigurationtblsensormaster>();
        }

        public int Sid { get; set; }
        public string SensorGroupName { get; set; }
        public string SensorDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<UnitworkccsConfigurationtblmachinesensor> UnitworkccsConfigurationtblmachinesensor { get; set; }
        public virtual ICollection<UnitworkccsConfigurationtblsensormaster> UnitworkccsConfigurationtblsensormaster { get; set; }
    }
}
