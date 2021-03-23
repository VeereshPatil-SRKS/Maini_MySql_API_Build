using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblholidays
    {
        public int HolidayId { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string Reason { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
