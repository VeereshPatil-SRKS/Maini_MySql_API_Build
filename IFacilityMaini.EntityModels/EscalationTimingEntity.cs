using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class EscalationTimingEntity
    {
        public class AddUpdateEscalationTm
        {
            public int id { get; set; }
            public int categoryId { get; set; }
            public string firstEsc { get; set; }
            public string secondEsc { get; set; }
            public string thirdEsc { get; set; }
            public string fourthEsc { get; set; }

        }


        public class ViewEscalationList
        {
            public int id { get; set; }
            public int categoryId { get; set; }

            public string categoryName { get; set; }
            public string firstEsc { get; set; }
            public string secondEsc { get; set; }
            public string thirdEsc { get; set; }
            public string fourthEsc { get; set; }

        }
    }
}
