using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Frommail
    {
        public int Id { get; set; }
        public string FromEmailAdd { get; set; }
        public string Password { get; set; }
        public int IsDeleted { get; set; }
        public string Username { get; set; }
        public string Domain { get; set; }
    }
}
