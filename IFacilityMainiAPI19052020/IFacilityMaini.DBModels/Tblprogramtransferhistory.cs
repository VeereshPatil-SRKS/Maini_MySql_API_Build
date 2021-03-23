using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblprogramtransferhistory
    {
        public int Pthid { get; set; }
        public int? MachineId { get; set; }
        public int? UserId { get; set; }
        public string ProgramName { get; set; }
        public DateTime? UploadedTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public int? ReturnStatus { get; set; }
        public string ReturnDesc { get; set; }
        public int? IsDeleted { get; set; }
        public int IsCompleted { get; set; }
        public int? Version { get; set; }
    }
}
