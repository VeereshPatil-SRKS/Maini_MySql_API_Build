using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class TblIssuedReceived
    {
        public int Id { get; set; }
        public int? ShiftId { get; set; }
        public int? OpId { get; set; }
        public int? MachineId { get; set; }
        public int? ReasonId { get; set; }
        public string SapCode { get; set; }
        public string GrnNo { get; set; }
        public string InspLotNo { get; set; }
        public string ToolLifeActual { get; set; }
        public int? ProductId { get; set; }
        public DateTime? IssueDate { get; set; }
        public string SapReferenceNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public int? OpAcceptanceFlag { get; set; }
        public int? IsReturn { get; set; }
        public int? ToolGribUserId { get; set; }
        public int? ToolGribUserFlag { get; set; }
        public string UniqueBatchNo { get; set; }
        public string SlipNo { get; set; }
        public string BarCodeNo { get; set; }
        public int? ReasonLvl1Id { get; set; }
        public string ToolBatchNo { get; set; }
        public int? IsReDisplay { get; set; }
        public string ToolName { get; set; }
        public int ReturnedOpId { get; set; }
        public string Remarks { get; set; }
        public DateTime? SapRefDate { get; set; }
        public string BatchNumber { get; set; }
        public int? Quantity { get; set; }
        public bool? IsCheck { get; set; }
        public int? IsSapgenerated { get; set; }
        public DateTime? SapGeneratedDate { get; set; }
    }
}
