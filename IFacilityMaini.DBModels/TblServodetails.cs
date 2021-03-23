using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblServodetails
    {
        public int Sdid { get; set; }
        public int? MachineId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public string ServoAxis { get; set; }
        public decimal? ServoLoadMeter { get; set; }
        public decimal? LoadCurrent { get; set; }
        public decimal? LoadCurrentAmp { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? Insertedby { get; set; }
        public int? IsDeleted { get; set; }
    }
}
