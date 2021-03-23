using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblHolidayManagment
    {
        public int HolidayManagmentId { get; set; }
        public string HolidayManagmentName { get; set; }
        public string HolidayManagmentDesc { get; set; }
        public int? HolidayType { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int DaysDuration { get; set; }
    }
}
