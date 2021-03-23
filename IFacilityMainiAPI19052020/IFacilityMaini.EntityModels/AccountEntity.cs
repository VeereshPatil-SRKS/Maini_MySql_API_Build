using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class AccountEntity
    {
        /// <summary>
        /// Login Data
        /// </summary>
        public class Account
        {
            public string userName { get; set; }
            public string password { get; set; }
        }

        /// <summary>
        /// Response Data
        /// </summary>
        public class AccountDetails
        {
            public int userId { get; set; }
            public int roleId { get; set; }
            public string roleName { get; set; }
            public string imageURL { get; set; }
            public string userFullName { get; set; }
            public string userName { get; set; }
            public string emailId { get; set; }
            public string phoneNumber { get; set; }
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
        }

        /// <summary>
        /// Account Details Send
        /// </summary>
        public class AccountDetailsSend
        {
            public int userId { get; set; }
            public int roleId { get; set; }
            public string roleName { get; set; }
            public string imageURL { get; set; }
            public string userFullName { get; set; }
            public string userName { get; set; }
            public string emailId { get; set; }
            public string phoneNumber { get; set; }
        }

        /// <summary>
        /// User Details
        /// </summary>
        public class UserDetail
        {
            public long userId { get; set; }
            public string userFirstname { get; set; }
            public string userLastName { get; set; }
            public string userFullName { get; set; }
            public string userName { get; set; }
            public string password { get; set; }
            public long? roleId { get; set; }
            public string personalEmailid { get; set; }
            public string professionalEmailId { get; set; }
            public string phoneNumber1 { get; set; }
            public string phoneNumber2 { get; set; }
        }
    }
}
