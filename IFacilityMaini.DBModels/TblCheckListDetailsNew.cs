using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblchecklistdetailsnew
    {
        public int CheckListNewId { get; set; }
        public int? CheckListId { get; set; }
        public int? HeaderId { get; set; }
        public string WhatToCheck { get; set; }
        public string How { get; set; }
        public string Frequency { get; set; }
        public string RunningHrs { get; set; }
        public int? PartsCount { get; set; }
        public string PeriodFrequency { get; set; }
        public string Date { get; set; }
        public string IsOk { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsDeleted { get; set; }
        public int? IsPrepared { get; set; }
        public int? IsApproved { get; set; }
        public string Comment { get; set; }
        public byte? IsNumeric { get; set; }
        public byte? IsText { get; set; }
        public int? RoleId { get; set; }
        public int? NumericValue { get; set; }
        public string TextValue { get; set; }
        public int? IsDashBoardEntry { get; set; }
        public int? Flag { get; set; }
        public int? AddEdit { get; set; }
        public int? IsAssigned { get; set; }
    }
}
