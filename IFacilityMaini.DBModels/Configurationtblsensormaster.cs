using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Configurationtblsensormaster
    {
        public int Smid { get; set; }
        public int IsAnalog { get; set; }
        public int Sid { get; set; }
        public int ChannelNo { get; set; }
        public int? MemoryAddress { get; set; }
        public int Unitid { get; set; }
        public string SensorDesc { get; set; }
        public decimal? ScalingFactor { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CountLow { get; set; }
        public int? CountHigh { get; set; }
        public int? SensorlimitLow { get; set; }
        public int? SensorlimitHigh { get; set; }
        public int Parametertypeid { get; set; }

        public virtual ConfigurationTblsensorgroup S { get; set; }
        public virtual Tblunit Unit { get; set; }
    }
}
