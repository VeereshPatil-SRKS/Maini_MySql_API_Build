using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblSaveNcprogVer
    {
        public int NcprogVerId { get; set; }
        public int MachineId { get; set; }
        public string ProgramNo { get; set; }
        public int VersionNo { get; set; }
        public string ProgramData { get; set; }
        public DateTime InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
