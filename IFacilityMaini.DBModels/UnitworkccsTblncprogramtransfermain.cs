using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblncprogramtransfermain
    {
        public int NcProgramTransferId { get; set; }
        public int? McId { get; set; }
        public string ProgramNumber { get; set; }
        public int? VersionNumber { get; set; }
        public string ProgramData { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public byte? FromCnc { get; set; }
    }
}
