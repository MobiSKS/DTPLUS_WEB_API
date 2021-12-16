using HPCL.DataRepository.Merchant;
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

    [Route("api/dtplus/merchant")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantRepository _merchantRepo;
        private readonly ILogger<MerchantController> _logger;
        public MerchantController(IMerchantRepository merchantRepo, ILogger<MerchantController> logger)
        {
            _merchantRepo = merchantRepo;
            _logger = logger;
        }
      
        [HttpPost]
        [Route("search_merchant")]
        public async Task<IActionResult> SearchMerchant()
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
