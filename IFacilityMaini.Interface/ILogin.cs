using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.LoginEntity;

namespace IFacilityMaini.Interface
{
    public interface ILogin
    {
        CommonResponse LoginDetails(LoginTrackerdetails data);
        CommonResponse Logout(int machineId,int operatorId);
        CommonResponse MaintainanceLoginDetails(string userName, string password);
        CommonResponseWithUserName AdminLoginDetails(string userName, string password);
        CommonResponse Login(string userName, string password);
    }
}
