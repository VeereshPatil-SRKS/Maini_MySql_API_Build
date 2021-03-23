using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmultipleworkorder
    {
        public int Mwoid { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public int? Wcid { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string MultipleWoname { get; set; }
        public string MultipleWodesc { get; set; }
        public int IsEnabled { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual Tblmachinedetails Wc { get; set; }
    }
}
