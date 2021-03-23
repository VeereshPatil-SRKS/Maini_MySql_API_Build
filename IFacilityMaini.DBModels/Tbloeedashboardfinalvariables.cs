using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tbloeedashboardfinalvariables
    {
        public int OeedashboardId { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public int? Wcid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Oee { get; set; }
        public decimal? Availability { get; set; }
        public decimal? Performance { get; set; }
        public decimal? Quality { get; set; }
        public int? IsOverallPlantWise { get; set; }
        public int? IsOverallShopWise { get; set; }
        public int? IsOverallWcwise { get; set; }
        public string Loss1Name { get; set; }
        public int? Loss1Value { get; set; }
        public string Loss2Name { get; set; }
        public int? Loss2Value { get; set; }
        public string Loss3Name { get; set; }
        public int? Loss3Value { get; set; }
        public string Loss4Name { get; set; }
        public int? Loss4Value { get; set; }
        public string Loss5Name { get; set; }
        public int? Loss5Value { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int IsDeleted { get; set; }
        public int IsOverallCellWise { get; set; }
        public int IsToday { get; set; }
    }
}
