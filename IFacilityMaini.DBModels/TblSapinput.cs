using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSapinput
    {
        public int SapInputId { get; set; }
        public string PathLocation { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int PathType { get; set; }
    }
}
