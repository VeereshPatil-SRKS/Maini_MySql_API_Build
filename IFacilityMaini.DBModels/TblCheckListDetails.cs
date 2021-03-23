using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class TblCheckListDetails
    {
        public int CheckListId { get; set; }
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
        public bool? IsNumeric { get; set; }
        public bool? IsText { get; set; }
        public int? RoleId { get; set; }
        public int? NumericValue { get; set; }
        public string TextValue { get; set; }
        public int? IsDashBoardEntry { get; set; }
        public int? PreviousChecklistId { get; set; }
        public int? IsEdited { get; set; }
    }
}
