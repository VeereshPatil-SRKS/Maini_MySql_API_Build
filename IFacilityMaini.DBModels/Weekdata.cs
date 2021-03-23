using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Weekdata
    {
        public int WeekId { get; set; }
        public int Value { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
