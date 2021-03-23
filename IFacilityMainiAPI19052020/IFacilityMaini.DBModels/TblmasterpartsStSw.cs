using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblmasterpartsStSw
    {
        public int Partsstswid { get; set; }
        public string PartNo { get; set; }
        public string OpNo { get; set; }
        public decimal? StdSetupTime { get; set; }
        public decimal? StdCuttingTime { get; set; }
        public decimal? StdChangeoverTime { get; set; }
        public decimal? InputWeight { get; set; }
        public decimal? OutputWeight { get; set; }
        public decimal? MaterialRemovedQty { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string StdSetupTimeUnit { get; set; }
        public string StdCuttingTimeUnit { get; set; }
        public string StdChangeoverTimeUnit { get; set; }
        public string InputWeightUnit { get; set; }
        public string OutputWeightUnit { get; set; }
        public string MaterialRemovedQtyUnit { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
