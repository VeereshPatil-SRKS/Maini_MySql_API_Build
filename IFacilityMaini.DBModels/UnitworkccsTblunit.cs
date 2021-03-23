using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblunit
    {
        public UnitworkccsTblunit()
        {
            UnitworkccsConfigurationtblsensordatalinkLogFreqUnit = new HashSet<UnitworkccsConfigurationtblsensordatalink>();
            UnitworkccsConfigurationtblsensordatalinkUnitNavigation = new HashSet<UnitworkccsConfigurationtblsensordatalink>();
            UnitworkccsConfigurationtblsensormaster = new HashSet<UnitworkccsConfigurationtblsensormaster>();
        }

        public int UId { get; set; }
        public string Unit { get; set; }
        public string UnitDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<UnitworkccsConfigurationtblsensordatalink> UnitworkccsConfigurationtblsensordatalinkLogFreqUnit { get; set; }
        public virtual ICollection<UnitworkccsConfigurationtblsensordatalink> UnitworkccsConfigurationtblsensordatalinkUnitNavigation { get; set; }
        public virtual ICollection<UnitworkccsConfigurationtblsensormaster> UnitworkccsConfigurationtblsensormaster { get; set; }
    }
}
