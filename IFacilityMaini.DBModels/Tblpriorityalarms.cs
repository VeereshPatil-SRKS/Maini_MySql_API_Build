using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblpriorityalarms
    {
        public int AlarmId { get; set; }
        public int AlarmNumber { get; set; }
        public string AlarmDesc { get; set; }
        public int AxisNo { get; set; }
        public string AlarmGroup { get; set; }
        public int PriorityNumber { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? MachineId { get; set; }
        public string CorrectedDate { get; set; }
        public int? IsMailSent { get; set; }
    }
}
