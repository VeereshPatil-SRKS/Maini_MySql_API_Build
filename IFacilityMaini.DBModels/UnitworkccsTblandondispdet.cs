using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblandondispdet
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

        public virtual UnitworkccsTblplant Plant { get; set; }
        public virtual UnitworkccsTblshop Shop { get; set; }
    }
}
