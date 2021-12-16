using HPCL.DataRepository.Account;
using HPCL.DataRepository.EncryptRequest;
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
    public class EncryptRequestController : ControllerBase
    {
        private readonly IEncryptRequestRepository _encryptRequestRepo;
        private readonly ILogger<EncryptRequestController> _logger;
        public EncryptRequestController(IEncryptRequestRepository encryptRequestRepo, ILogger<EncryptRequestController> logger)
        {
            _encryptRequestRepo = encryptRequestRepo;
            _logger = logger;
        }


        [HttpPost]
        [Route("encrypt_request")]
        public async Task<IActionResult> EncryptRequest()
        {


            try
            {
                return Ok("EncryptRequest");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
       
    }
}
