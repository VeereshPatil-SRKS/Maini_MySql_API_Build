using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tbltosapshopnames
    {
        public int ToSapshopNamesId { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsSetupShown { get; set; }
    }
}
