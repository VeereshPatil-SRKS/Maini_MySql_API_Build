using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ListOfStoppageEntity
    {
        public class AddAndEditStoppage
        {
            public int stoppageId { get; set; }
            public int categoryId { get; set; }
            public int alarmNo { get; set; }
            public string alarmDesc { get; set; }
            public int sourceId { get; set; }
            
        }

        public class UploadStoppage
        {
            public string categoryName { get; set; }
            public int alarmNo { get; set; }
            public string alarmDesc { get; set; }
            public string sourceName { get; set; }
        }
    }
}
