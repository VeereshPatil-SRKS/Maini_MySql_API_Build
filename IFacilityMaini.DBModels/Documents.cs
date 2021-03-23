using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Documents
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string PartNumber { get; set; }
        public int? OperationNumber { get; set; }
        public string SerialNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentUrl { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string RevisionNumber { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string RevisionReason { get; set; }
    }
}
