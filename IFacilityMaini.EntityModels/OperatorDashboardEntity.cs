using IFacilityMaini.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class OperatorDashboardEntity
    {
        //public class MachineDetails
        //{
        //    public int machineId { get; set; }
        //    public string machineInvNo { get; set; }
        //    public string machineDispName { get; set; }
        //    public string machineMake { get; set; }
        //    public string machineModel { get; set; }
        //    public int plantId { get; set; }
        //    public int shopId { get; set; }
        //    public int cellId { get; set; }
        //}

        public class MachineDetails
        {
            public int? machineId { get; set; }
            public string machineInvNo { get; set; }
            public string machineDispName { get; set; }
            public string machineMake { get; set; }
            public string machineModel { get; set; }
            public TblRaisedTicket tblRaisedTicket { get; set; }
            public bool isLoggedIn { get; set; }
            public int? operatorId { get; set; }
            public string operatorName { get; set; }
            public int? FgPartId { get; set; }
            public int? ticketId { get; set; }
            public string loginTime { get; set; }
            public string loginDate { get; set; }
            public string shift { get; set; }
            public bool fgPartFlag { get; set; }
            public bool dtTicketFlag { get; set; }
            public string status { get; set; }
            public string cellName { get; set; }
            public string subCellName { get; set; }
            public string partNo { get; set; }
            public int? operationNo { get; set; }
            public string workOrderNo { get; set; }
            public string fgPartDesc { get; set; }
            public int woBalanceQty { get; set; }
            public int runningBalance {get; set;}
            public int ticketClsByMaintainTeam { get; set; }
            public dynamic responseGraph { get; set; }
            public int dryRunFlag { get; set; }
            public int? dryRunId { get; set; }
            public string dryRunStatus { get; set; }
            public string statusColor { get; set; }
            public string dryRunUserName { get; set; }
            public string dmcCodeStatus { get; set; }
        }

        public class Machines
        {
            public int MachineID { get; set; }
            public string MachineName { get; set; }
            public string PowerOnTime { get; set; }
            public string RunningTime { get; set; }
            public string CuttingTime { get; set; }
            public string CurrentStatus { get; set; }
            public string ExeProgramName { get; set; }
            public int? PartsCount { get; set; }
            public string Color { get; set; }
            public string IdleTime { get; set; }
            public string CycleTime { get; set; }
            public string Time { get; set; }
        }

        public class SocketDetails
        {
            public string SocketName { get; set; }
            public string colour { get; set; }
            public int machineId { get; set; }
        }

        public class ToolAndSocketDetails
        {
            public string SocketName { get; set; }
            public string ToolNumber { get; set; }
            public int? MachineId { get; set; }
            public int? StandardToolLife { get; set; }
            public int? ActaulToolLife { get; set; }
        }
    }
}
