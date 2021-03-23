using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblMachineMakeDetails
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int? PlantId { get; set; }
        public int? MachineCategoryId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsActive { get; set; }
    }
}
