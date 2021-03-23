using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblProdPlanMasters
    {
        public int ProdPlanId { get; set; }
        public string WorkCenter { get; set; }
        public string ProdOrderNo { get; set; }
        public string OperationNo { get; set; }
        public string Status { get; set; }
        public string Fgcode { get; set; }
        public int OrderQty { get; set; }
        public int? SplitOrderQty { get; set; }
        public string QtyUnit { get; set; }
        public DateTime InsertedOn { get; set; }
    }
}
