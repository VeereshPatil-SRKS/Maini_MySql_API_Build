using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFacilityMaini.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.LoginEntity;

namespace IFacilityMaini.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin login;
        public LoginController(ILogin _login)
        {
            login = _login;
        }

        /// <summary>
        /// Login Details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login/LoginDetails")]
        public async Task<IActionResult> LoginDetails(LoginTrackerdetails data)
        {
            CommonResponse response = login.LoginDetails(data);
            return Ok(response);
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/Logout")]
        public async Task<IActionResult> Logout(int machineId,int operatorId)
        {
            CommonResponse response = login.Logout(machineId, operatorId);
            return Ok(response);
        }

        /// <summary>
        /// Maintainance Login Details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/MaintainanceLoginDetails")]
        public async Task<IActionResult> MaintainanceLoginDetails(string userName, string password)
        {
            CommonResponse response = login.MaintainanceLoginDetails(userName, password);
            return Ok(response);
        }

        /// <summary>
        /// Admin Login Details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/AdminLoginDetails")]
        public async Task<IActionResult> AdminLoginDetails(string userName, string password)
        {
            CommonResponseWithUserName response = login.AdminLoginDetails(userName, password);
            return Ok(response);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/Login")]
        public async Task<IActionResult> Login(string userName, string password)
        {
            CommonResponse response = login.Login(userName, password);
            return Ok(response);
        }
    }
}