using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class EscationMatrixEntity
    {
        public class EscalationMatrixDetails
        {
            public long escalationId { get; set; }
            public int employeeId { get; set; }
            public string employeeName { get; set; }
            public string cell { get; set; }
            public string subCell { get; set; }
            public string category { get; set; }
            public string shift { get; set; }
            public string smsPriority { get; set; }

        }


        //public class EscalationMatrixCustom
        //{
        //    public long escalationId { get; set; }
        //    public string emaployeeName { get; set; }
        //    public int opNo { get; set; }
        //    public string contactNo { get; set; }
        //    public int plantId { get; set; }
        //    public int cellId { get; set; }
        //    public int subCellId { get; set; }
        //    public int roleId { get; set; }
        //    public int categoryId { get; set; }
        //    public string shift { get; set; }
        //    public int machineId { get; set; }
        //    public int smsPriority { get; set; }
        //    public string time { get; set; }
        //}
        public class EscalationMatrixCustom
        {
            public long escalationId { get; set; }
            public int employeeId { get; set; }
            public string emaployeeName { get; set; }
            public string cellId { get; set; }
            public string subCellId { get; set; }
            public string categoryId { get; set; }
            public string shift { get; set; }
            public string smsPriority { get; set; }

        }


        public class EscalationMatrixCustomView
        {
            public long escalationId { get; set; }
            public int employeeId { get; set; }
            public string emaployeeName { get; set; }
            public int opId { get; set; }

            // public int cellId { get; set; }
            public List<cellDet> cellDet { get; set; }
            //  public int subCellId { get; set; }
            public List<subcellDet1> subCellDet { get; set; }
            //  public int categoryId { get; set; }
            public List<categoryDet> categoryDet { get; set; }
            public List<shiftDet> shiftDets { get; set; }
            public List<smsPriorityDet> smsPriorityDet { get; set; }

        }

        public class smsPriorityDet
        {

            public int priorityId { get; set; }
            public string priorityName { get; set; }
        }



        public class subCellDet
        {

            public int subCellId { get; set; }
            public string subCellName { get; set; }
        }

        public class shiftDet
        {
            public int shiftId { get; set; }
            public string shiftName { get; set; }
        }

        public class cellDet
        {
            public int cellId { get; set; }
            public string cellName { get; set; }
        }


        public class subcellDet1
        {
            public int subCellId { get; set; }
            public string subCellName { get; set; }
        }

        public class categoryDet
        {
            public int categoryId { get; set; }
            public string categoryName { get; set; }
        }

        public class viewEmpDet
        {

            public string employeeId { get; set; }
            public string employeeName { get; set; }
        }
    }
}
