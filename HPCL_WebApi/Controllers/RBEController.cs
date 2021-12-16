using HPCL.DataRepository.RBE;
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

    [Route("api/dtplus/rbe")]
    [ApiController]
    public class RBEController : ControllerBase
    {
        private readonly IRBERepository _rbeRepo;
        private readonly ILogger<RBEController> _logger;
        public RBEController(IRBERepository rbeRepo, ILogger<RBEController> logger)
        {
            _rbeRepo = rbeRepo;
            _logger = logger;
        }

        [HttpPost]
        [Route("get_all_rbe_list")]
        public async Task<IActionResult> GetAllRBEList()
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
