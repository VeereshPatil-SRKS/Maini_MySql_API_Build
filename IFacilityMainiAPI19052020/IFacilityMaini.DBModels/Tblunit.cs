using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblunit
    {
        public Tblunit()
        {
            ConfigurationtblsensordatalinkLogFreqUnit = new HashSet<Configurationtblsensordatalink>();
            ConfigurationtblsensordatalinkUnitNavigation = new HashSet<Configurationtblsensordatalink>();
            Configurationtblsensormaster = new HashSet<Configurationtblsensormaster>();
            Tblparts = new HashSet<Tblparts>();
        }

        public int UId { get; set; }
        public string Unit { get; set; }
        public string UnitDesc { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Configurationtblsensordatalink> ConfigurationtblsensordatalinkLogFreqUnit { get; set; }
        public virtual ICollection<Configurationtblsensordatalink> ConfigurationtblsensordatalinkUnitNavigation { get; set; }
        public virtual ICollection<Configurationtblsensormaster> Configurationtblsensormaster { get; set; }
        public virtual ICollection<Tblparts> Tblparts { get; set; }
    }
}
