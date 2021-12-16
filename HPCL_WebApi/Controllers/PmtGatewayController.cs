
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
using HPCL.DataRepository.PmtGateway;

namespace HPCL_WebApi.Controllers
{

    [Route("api/dtplus/gateway")]
    [ApiController]
    public class PmtGatewayController : ControllerBase
    {
        private readonly IPmtGatewayRepository _pmtGatewayRepo;
        private readonly ILogger<PmtGatewayController> _logger;
        public PmtGatewayController(IPmtGatewayRepository pmtGatewayRepo, ILogger<PmtGatewayController> logger)
        {
            _pmtGatewayRepo = pmtGatewayRepo;
            _logger = logger;
        }

        [HttpPost]
        [Route("create_checksumhash")]
        public async Task<IActionResult> CreateChecksumhash()
        {


            try
            {
                return Ok("CreateChecksumhash");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
