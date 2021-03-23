using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblCategoryDetails
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryIdDesc { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
