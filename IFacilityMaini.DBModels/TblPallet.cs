using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblPallet
    {
        public int PalletId { get; set; }
        public string PalletName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
