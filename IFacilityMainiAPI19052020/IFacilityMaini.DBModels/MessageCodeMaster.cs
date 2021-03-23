using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class MessageCodeMaster
    {
        public int MessageCodeId { get; set; }
        public string MessageCode { get; set; }
        public string MessageMcode { get; set; }
        public string MessageDescription { get; set; }
        public string MessageType { get; set; }
        public DateTime InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
        public string ReportDispName { get; set; }
        public string ColourCode { get; set; }
    }
}
