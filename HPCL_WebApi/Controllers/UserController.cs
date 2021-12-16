using HPCL.DataModel.User;
using HPCL.DataRepository.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("api/dtplus/user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<WalletController> _logger;

        private readonly IUserRepository _userRepo;

        public UserController(ILogger<WalletController> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        [HttpPost]
        [Route("customer_user_registration")]
        public async Task<IActionResult> customeruserregistration()
        {
            try
            {
                return Ok("set_sale_limits_of_cards");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

    }
}
