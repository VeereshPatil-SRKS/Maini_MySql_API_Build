using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblBreakDownTickect
    {
        public int Id { get; set; }
        public int? MachineId { get; set; }
        public int? ReasonId { get; set; }
        public string OperatorId { get; set; }
        public int? MntOpId { get; set; }
        public int? ProdOpId { get; set; }
        public DateTime? BdTktDateTime { get; set; }
        public bool? MntStatus { get; set; }
        public string MntRrejectReason { get; set; }
        public DateTime? MntAcpRejDateTime { get; set; }
        public string MntRemarks { get; set; }
        public DateTime? TktClosingTime { get; set; }
        public int? MntClosureOpId { get; set; }
        public DateTime? ProdAcpRejDateTime { get; set; }
        public bool? ProdStatus { get; set; }
        public string ProdRemarks { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? WoId { get; set; }
        public DateTime? CorrectedDate { get; set; }
        public int? AcceptFlage { get; set; }
        public int? MaintFlage { get; set; }
        public int? MaintFinished { get; set; }
        public int? ProdFinished { get; set; }
        public int? MaintRejId { get; set; }
        public int? ProdRejId { get; set; }

        public virtual Tblmachinedetails Machine { get; set; }
        public virtual TblBreakdowncodes Reason { get; set; }
        public virtual Tblworkorderentry Wo { get; set; }
    }
}
