using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ProgramMaster
    {
        public int ProgramId { get; set; }
        public string EmployeeCode { get; set; }
        public string ComponentDescription { get; set; }
        public string ComponentCode { get; set; }
        public string OperationDescription { get; set; }
        public string WorkOrderNo1 { get; set; }
        public string WorkOrderNo2 { get; set; }
        public string WorkOrderNo3 { get; set; }
        public int MachineId { get; set; }
        public DateTime InsertedOn { get; set; }
        public DateTime ProgramDate { get; set; }
        public TimeSpan ProgramTime { get; set; }
        public DateTime ProgramDateTime { get; set; }
        public string OpnCode1 { get; set; }
        public int PartsProduced1 { get; set; }
        public int PartsAccepted1 { get; set; }
        public string OpnCode2 { get; set; }
        public int? PartsProduced2 { get; set; }
        public int? PartsAccepted2 { get; set; }
        public string OpnCode3 { get; set; }
        public int? PartsProduced3 { get; set; }
        public int? PartsAccepted3 { get; set; }
        public string Shift { get; set; }
        public int? PartsRejected1 { get; set; }
        public int? PartsRejected2 { get; set; }
        public int? PartsRejected3 { get; set; }
        public DateTime? CorrectedDate { get; set; }
    }
}
