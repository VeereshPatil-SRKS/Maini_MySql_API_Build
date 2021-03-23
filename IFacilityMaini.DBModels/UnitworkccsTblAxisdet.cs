using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblAxisdet
    {
        public UnitworkccsTblAxisdet()
        {
            UnitworkccsConfigurationtblsensordatalink = new HashSet<UnitworkccsConfigurationtblsensordatalink>();
        }

        public int AxisDetId { get; set; }
        public int MachineId { get; set; }
        public int AxisId { get; set; }
        public string AxisName { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
        public int SpindlePath { get; set; }

        public virtual ICollection<UnitworkccsConfigurationtblsensordatalink> UnitworkccsConfigurationtblsensordatalink { get; set; }
    }
}
