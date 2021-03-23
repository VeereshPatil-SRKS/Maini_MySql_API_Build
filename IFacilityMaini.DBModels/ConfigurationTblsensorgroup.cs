using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ConfigurationTblsensorgroup
    {
        public ConfigurationTblsensorgroup()
        {
            Configurationtblmachinesensor = new HashSet<Configurationtblmachinesensor>();
            Configurationtblsensormaster = new HashSet<Configurationtblsensormaster>();
        }

        public int Sid { get; set; }
        public string SensorGroupName { get; set; }
        public string SensorDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Configurationtblmachinesensor> Configurationtblmachinesensor { get; set; }
        public virtual ICollection<Configurationtblsensormaster> Configurationtblsensormaster { get; set; }
    }
}
