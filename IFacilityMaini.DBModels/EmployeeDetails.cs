using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class EmployeeDetails
    {
        public int Id { get; set; }
        public int? EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Grade { get; set; }
        public int? PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantCode { get; set; }
        public int? DepartmentId { get; set; }
        public string Department { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeNumber { get; set; }
        public int? DivisionId { get; set; }
        public string DivisionName { get; set; }
    }
}
