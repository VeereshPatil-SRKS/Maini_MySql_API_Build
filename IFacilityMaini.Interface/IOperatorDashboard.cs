using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Interface
{
    public interface IOperatorDashboard
    {
        CommonResponse RedirectThePage(string HostName, string IpAddress);
        CommonResponseGraph GetTheMachineDetails(string HostName, string IpAddress);
        CommonResponse GetIpAddressAndHostName();
        ResponseMessage GraphDetails(int machineId);
        //CommonResponse CheckMacIdleAndSendToMsg(int machineId);
        CommonResponse ToolLifeManagement(int machineId);
    }
}
