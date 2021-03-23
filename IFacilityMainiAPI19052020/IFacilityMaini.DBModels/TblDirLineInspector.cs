using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblDirLineInspector
    {
        public int DirLineInspId { get; set; }
        public int? PlantId { get; set; }
        public int? CellId { get; set; }
        public int? SubCellId { get; set; }
        public int? MachineId { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public string WorkorderNumber { get; set; }
        public int? OperatorId { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantity { get; set; }
        public string DefectCode { get; set; }
        public string DefectDescription { get; set; }
        public string PartQrCode { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string Shift { get; set; }
        public int? PartId { get; set; }
        public int? OpNo { get; set; }
        public int? PlanLinckageId { get; set; }
        public int? WoQty { get; set; }
        public int? DefectCodeId { get; set; }
    }
}
