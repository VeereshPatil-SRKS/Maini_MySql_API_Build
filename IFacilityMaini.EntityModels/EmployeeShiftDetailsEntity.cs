using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class EmployeeShiftDetailsEntity
    {
        public class AddUpdateOperatorShift
        {
            public int id { get; set; }
            public int employeeId { get; set; }
            public string shift { get; set; }
            public string machineIds { get; set; }
            public string fromDate { get; set; }
            public string toDate { get; set; }
        }

        //public class AddUpdateOperatorShiftExcel
        //{

        //    public int opId { get; set; }
        //    public int employeeId { get; set; }
        //    public string shift { get; set; }
        //    public string machines { get; set; }
        //    public string fromDate { get; set; }
        //    public string toDate { get; set; }

        //}


        public class AddUpdateOperatorShiftExcel
        {
            public string fromDate { get; set; }
            public List<OperatorShiftExcelList> employeeList { get; set; }
            public string toDate { get; set; }
        }

        public class OperatorShiftExcelList
        {
            public int employeeId { get; set; }
            public string shift { get; set; }
            public string machines { get; set; }

        }

        public class OperatorDetailsShift
        {
            public int id { get; set; }
            public int employeeId { get; set; }
            public string employeeName { get; set; }
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public string designation { get; set; }
            public string department { get; set; }
            public string Cell { get; set; }
            public string subCell { get; set; }
            public string shift { get; set; }
            public string shiftId { get; set; }
            public int? employeeNo { get; set; }
            public int? opId { get; set; }
            public List<MachineDetails1> machinesList { get; set; }

        }

        public class MachineDetails1
        {
            public int machineId { get; set; }
            public string machineName { get; set; }
        }

        public class DownloadPdf
        {
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public int cellId { get; set; }
            public int subCellId { get; set; }
            public int departmentId { get; set; }
        }
    }
}
