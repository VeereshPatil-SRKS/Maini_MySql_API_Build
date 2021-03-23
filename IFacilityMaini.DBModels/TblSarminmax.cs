using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSarminmax
    {
        public int Smid { get; set; }
        public decimal? Sarmin { get; set; }
        public decimal? Sarmax { get; set; }
        public string Sarstatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int Isdeleted { get; set; }
        public int? Sid { get; set; }
    }
}
