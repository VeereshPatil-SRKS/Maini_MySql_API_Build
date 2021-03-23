using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblhistpms
    {
        public int Id { get; set; }
        public int Machineid { get; set; }
        public int Pmsid { get; set; }
        public int Pmcheckpointid { get; set; }
        public string Pmchecklistname { get; set; }
        public int? Workdone { get; set; }
        public string Remarks { get; set; }
        public string CorrectedDate { get; set; }
        public int Cellid { get; set; }
    }
}
