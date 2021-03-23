using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblRoutingNo
    {
        public int Id { get; set; }
        public int? PlantId { get; set; }
        public int? CellId { get; set; }
        public int? SubCellId { get; set; }
        public string RoutingNo { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? FgPartId { get; set; }
        public int? ChildFgPartId { get; set; }
        public int? OperationNo { get; set; }
        public string ProducedItemDescription { get; set; }
    }
}
