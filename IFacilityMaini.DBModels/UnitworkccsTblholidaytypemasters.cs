using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblholidaytypemasters
    {
        public int HolidayTypeId { get; set; }
        public string HolidayTypeName { get; set; }
        public string HolidayTypeColorCode { get; set; }
        public byte? IsActive { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
