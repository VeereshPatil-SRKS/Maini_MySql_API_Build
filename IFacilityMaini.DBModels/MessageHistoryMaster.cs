using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class MessageHistoryMaster
    {
        public int MessageId { get; set; }
        public string Meassage { get; set; }
        public DateTime MessageDate { get; set; }
        public TimeSpan MessageTime { get; set; }
        public DateTime MessageDateTime { get; set; }
        public string MessageNo { get; set; }
        public string MessageCode { get; set; }
        public string MessageType { get; set; }
        public string MessageShift { get; set; }
        public int? MachineId { get; set; }
        public DateTime? InsertedOn { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public int? IsProgLock { get; set; }
    }
}
