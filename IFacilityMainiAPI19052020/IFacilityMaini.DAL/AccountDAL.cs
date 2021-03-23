using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.AccountEntity;
using IFacilityMaini.DAL.App_Start;
using IFacilityMaini.DAL.Resource;

namespace IFacilityMaini.DAL
{
    public class AccountDAL : IAccount
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(AccountDAL));

        public AccountDAL(unitworksccsContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="data"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public AccountDetails Login(Account data, string userId = null)
        {
            AccountDetails obj = new AccountDetails();
            try
            {
                Security security = new Security();

                string password = security.Encrypt(data.password);

                var userItem = (from user in db.Tblusers
                                where user.Password == data.password &&
                                user.UserName == data.userName
                                select user).FirstOrDefault();
                if (userItem != null)
                {
                    //userItem.isOnline = true;
                    //db.SaveChanges();

                    obj.userName = userItem.UserName;
                    obj.userFullName = userItem.UserName;
                    //obj.emailId = userItem.EmailId;
                    //obj.phoneNumber = userItem.;
                    obj.roleId = Convert.ToInt32(userItem.PrimaryRole);
                    obj.roleName = db.Tblroles.Where(m => m.RoleId == obj.roleId).FirstOrDefault().RoleDesc;
                    obj.userId = Convert.ToInt32(userItem.UserId);
                    obj.isStatus = true;

                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.LoginUnSuccessful;
                }



            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.ExceptionMessage;
            }
            return obj;
        }

    }
}
