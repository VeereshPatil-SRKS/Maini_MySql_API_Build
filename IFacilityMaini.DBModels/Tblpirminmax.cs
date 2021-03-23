using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblpirminmax
    {
        public int Pmid { get; set; }
        public decimal? Pirmin { get; set; }
        public decimal? Pirmax { get; set; }
        public string Pirstatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int Isdeleted { get; set; }
        public int? Pid { get; set; }
    }
}
