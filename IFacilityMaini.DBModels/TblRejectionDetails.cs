using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblRejectionDetails
    {
        public int RejectionId { get; set; }
        public int? FgPartId { get; set; }
        public int? DefectCodeId { get; set; }
        public int? DefectQty { get; set; }
        public int? MachineId { get; set; }
        public int? OperatorId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public string QrCodeNo { get; set; }
        public int? IsDirLineInsp { get; set; }
        public int? IsDirQualityHead { get; set; }
        public string DmcCodeStatus { get; set; }
        public string ReasonForRejection { get; set; }
    }
}
