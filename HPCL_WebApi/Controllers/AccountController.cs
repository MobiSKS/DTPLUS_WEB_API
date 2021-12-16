using HPCL.DataRepository.Account;
using HPCL.DataRepository.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

namespace HPCL_WebApi.Controllers
{

    [Route("api/dtplus")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepo;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountRepository accountRepo, ILogger<AccountController> logger)
        {
            _accountRepo = accountRepo;
            _logger = logger;
        }

       
        [HttpPost]
        [Route("generatetoken")]
        public async Task<IActionResult> GenerateToken()
        {


            try
            {
                return Ok("Token");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("/api/Account")]
        public async Task<IActionResult> AccountDetsils()
        {


            try
            {
                return Ok("Account");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
