using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblBookStock
    {
        public long BookStockId { get; set; }
        public string BookStockName { get; set; }
        public string BookStockDesc { get; set; }
        public string ToolSapCode { get; set; }
        public string PlantCode { get; set; }
        public long? PlantId { get; set; }
        public string SapLoaction { get; set; }
        public long? Quantity { get; set; }
        public string SapBatch { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? Createdby { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
