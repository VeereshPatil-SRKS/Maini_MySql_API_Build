using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSar
    {
        public int Sid { get; set; }
        public string OpNo { get; set; }
        public string BallunNo { get; set; }
        public string PartNo { get; set; }
        public string Specification { get; set; }
        public string ProdAndLocation { get; set; }
        public string SpecialChar { get; set; }
        public string Freq { get; set; }
        public string ProdQuality { get; set; }
        public string RejarctionQuality { get; set; }
        public int? MachineId { get; set; }
        public string Shift { get; set; }
        public string Responsibility { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int IsDeleted { get; set; }
    }
}
