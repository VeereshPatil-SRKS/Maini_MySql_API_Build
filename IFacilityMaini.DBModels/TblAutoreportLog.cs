using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblAutoreportLog
    {
        public int AutoReportLogId { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public int? AutoReportId { get; set; }
        public DateTime? InsertedOn { get; set; }
        public int? ExcelCreated { get; set; }
        public int? MailSent { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ExcelCreatedTime { get; set; }

        public virtual TblAutoreportsetting AutoReport { get; set; }
    }
}
