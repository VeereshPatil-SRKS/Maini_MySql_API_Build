using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblMaterialMaster
    {
        public long MaterialmasterId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDescription { get; set; }
        public string PlantCode { get; set; }
        public int? PlantId { get; set; }
        public string PartCode { get; set; }
        public string PartDescription { get; set; }
        public string Uom { get; set; }
        public string MaterialType { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
