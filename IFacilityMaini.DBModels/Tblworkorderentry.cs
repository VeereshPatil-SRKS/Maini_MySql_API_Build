using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblworkorderentry
    {
        public Tblworkorderentry()
        {
            TblBreakDownTickect = new HashSet<TblBreakDownTickect>();
            TblProdAndonDisp = new HashSet<TblProdAndonDisp>();
            Tblrejectqty = new HashSet<Tblrejectqty>();
        }

        public int Hmiid { get; set; }
        public int MachineId { get; set; }
        public DateTime Wostart { get; set; }
        public DateTime? Woend { get; set; }
        public string PartNo { get; set; }
        public int ShiftId { get; set; }
        public string OperatorId { get; set; }
        public string ProdOrderNo { get; set; }
        public string OperationNo { get; set; }
        public int YieldQty { get; set; }
        public int ScrapQty { get; set; }
        public int TotalQty { get; set; }
        public int ProcessQty { get; set; }
        public int Status { get; set; }
        public DateTime CorrectedDate { get; set; }
        public int IsStarted { get; set; }
        public int IsFinished { get; set; }
        public int IsPartialFinish { get; set; }
        public int IsWorkOrder { get; set; }
        public DateTime PestartTime { get; set; }
        public int IsMultiWo { get; set; }
        public int IsHold { get; set; }
        public int IsFlag { get; set; }
        public int? ProdOrderQty { get; set; }
        public string Fgcode { get; set; }
        public int? HoldCodeId { get; set; }
        public DateTime? HoldTime { get; set; }
        public int? HoldDuration { get; set; }
        public bool? IsSplit { get; set; }
        public int? CellId { get; set; }
        public int? SyncInsert { get; set; }
        public int? PartsPerCycle { get; set; }
        public int IsReWork { get; set; }
        public int ReWorkStart { get; set; }
        public int ReWorkEnd { get; set; }
        public int? ReWorkReasonId { get; set; }
        public DateTime? ReworkStartTime { get; set; }
        public DateTime? ReworkEndTime { get; set; }

        public virtual ICollection<TblBreakDownTickect> TblBreakDownTickect { get; set; }
        public virtual ICollection<TblProdAndonDisp> TblProdAndonDisp { get; set; }
        public virtual ICollection<Tblrejectqty> Tblrejectqty { get; set; }
    }
}
