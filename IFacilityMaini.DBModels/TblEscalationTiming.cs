using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblEscalationTiming
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string FirstEscalation { get; set; }
        public string SecondEscalation { get; set; }
        public string ThirdEscalation { get; set; }
        public string FourthEscalation { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
