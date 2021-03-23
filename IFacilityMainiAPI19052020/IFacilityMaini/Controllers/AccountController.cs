using System;
using System.Threading.Tasks;
using IFacilityMaini.DAL.App_Start;
using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.Interface;
using IFacilityMaini.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using static IFacilityMaini.EntityModels.AccountEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.Controllers
{
    public class AccountController : ControllerBase
    {
        private IUserService _userService;

        private readonly AppSettings _appSettings;
        private readonly IAccount account;

        public AccountController(IUserService userService, IOptions<AppSettings> appSettings, IAccount _account)
        {
            _userService = userService;
            _appSettings = appSettings.Value;
            account = _account;
        }

        /// <summary>
        /// Login with out any intergration
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Account/Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]Account data)
        {

            CommonResponseLogin response = new CommonResponseLogin();
            AccountDetails responseGet = new AccountDetails();
            AccountDetailsSend accountDetails = new AccountDetailsSend();
            string userId = "";

            responseGet = account.Login(data, userId);

            if (responseGet.isStatus == true)
            {
                userId = responseGet.userId.ToString();
                accountDetails.userName = responseGet.userName;
                accountDetails.userFullName = responseGet.userFullName;
                accountDetails.emailId = responseGet.emailId;
                accountDetails.phoneNumber = responseGet.phoneNumber;
                accountDetails.roleId = Convert.ToInt32(responseGet.roleId);
                accountDetails.roleName = responseGet.roleName;
                accountDetails.userId = Convert.ToInt32(responseGet.userId);
                response.isStatus = true;
                response.response = accountDetails;

                Security security = new Security();

                string password = security.Encrypt(data.password);

                string token = _userService.Authenticate(data.userName, data.password);
                response.token = token;
                //RolePermissionOnLogin rolePermission = new RolePermissionOnLogin();
                //rolePermission = account.RolePermission(accountDetails.roleId);
                //response.rolePermission = rolePermission;
                //var user = _userService.Authenticate(userParam.Username, userParam.Password);

                //if (user == null)
                //    return BadRequest(new { message = "Username or password is incorrect" });


            }
            else
            {
                response.isStatus = false;
                response.response = ResourceResponse.LoginUnSuccessful;
                response.token = "";
            }
            
            return Ok(response);
        }

    }
}