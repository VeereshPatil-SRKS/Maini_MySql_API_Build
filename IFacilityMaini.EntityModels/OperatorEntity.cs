using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class OperatorEntity
    {
        public class AddUpdateOperator
        {

            public int opId { get; set; }
            public string employeeName { get; set; }
            public int opNo { get; set; }
            public int businessId { get; set; }
            public int plantId { get; set; }
            public int departmentId { get; set; }
            public int categoryId { get; set; }
            public string directOrIndirect { get; set; }
            public int photoId { get; set; }
            public int roleId { get; set; }
            public int cellId { get; set; }
            public int subCellId { get; set; }
            public string conatctNo { get; set; }
            public string emailId { get; set; }
            public string dateOfBirth { get; set; }
            public string dateOfJoining { get; set; }
        }


        public class OperatorCustom
        {
            public int opId { get; set; }
            public string employeeName { get; set; }
            public int employeeId { get; set; }
            public string contactNo { get; set; }
            public string plant { get; set; }
            public string cell { get; set; }
            public string subCell { get; set; }
            public string role { get; set; }
            public string category { get; set; }
            public string business { get; set; }
            public string department { get; set; }
            public string directOrIndirect { get; set; }
            // public string emailId { get; set; }
            public string dateOfBirth { get; set; }
            public string dateOfJoining { get; set; }



            //  public string shift { get; set; }
            //   public string machineName { get; set; }






        }

        //public class OperatorCustom
        //{
        //    public int opId { get; set; }
        //    public string employeeName { get; set; }
        //    public int opNo { get; set; }
        //    public string contactNo { get; set; }
        //    public string plant { get; set; }
        //    public string cell { get; set; }
        //    public string subCell { get; set; }
        //    public string role { get; set; }
        //    public string category { get; set; }
        //    public string shift { get; set; }
        //    public string machineName { get; set; }
        //}

        public class OperatorDetails
        {
            public int opId { get; set; }
            public string employeeName { get; set; }
            public int? opNo { get; set; }
            public string contactNo { get; set; }
            public string emailId { get; set; }
            public string cellName { get; set; }
            public int? cellId { get; set; }
            public string subCellName { get; set; }
            public int? subCellId { get; set; }
            public string roleName { get; set; }
            public int? roleId { get; set; }
            public int? departmentId { get; set; }
            public string departmentName { get; set; }
            public string categoryName { get; set; }
            public int? categoryId { get; set; }
            public int? businessId { get; set; }
            public string businessName { get; set; }
            public string directOrIndirect { get; set; }
            public int? plantId { get; set; }
            public string plantName { get; set; }
            public string dateOfBirth { get; set; }
            public string dateOfJoining { get; set; }
            public int photoId { get; set; }
            public string photoUrl { get; set; }
        }

        public class MachineDetails1
        {
            public int machineid { get; set; }
            public string machinename { get; set; }
        }
    }
}
