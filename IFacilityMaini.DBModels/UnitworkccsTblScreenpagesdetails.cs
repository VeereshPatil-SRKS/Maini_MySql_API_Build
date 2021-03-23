using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblScreenpagesdetails
    {
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public string ScreenDisc { get; set; }
        public string ScreenUrl { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatredOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
