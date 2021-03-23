using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblreworkdetails
    {
        public int ReworkId { get; set; }
        public int? FgPartId { get; set; }
        public int? DefectCodeId { get; set; }
        public int? DefectQty { get; set; }
        public int? MachineId { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string CorrectedDate { get; set; }
        public string Shift { get; set; }
        public string QrCodeNo { get; set; }
        public int? IsDirQualityHead { get; set; }
        public int? IsDirLineInsp { get; set; }
        public string DmcCodeStatus { get; set; }
        public string ReasonForRework { get; set; }
    }
}
