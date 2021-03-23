using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAndonDispDet
    {
        public int Andondispid { get; set; }
        public string Ipaddress { get; set; }
        public int PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDeleted { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
    }
}
