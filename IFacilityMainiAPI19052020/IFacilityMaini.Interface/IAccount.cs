using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.AccountEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IAccount
    {
        AccountDetails Login(Account data, string userId);
    }
}
