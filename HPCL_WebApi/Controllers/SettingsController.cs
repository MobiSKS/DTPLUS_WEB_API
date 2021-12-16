using HPCL.DataModel.Settings;
using HPCL.DataRepository.Settings;
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
    [Route("/api/dtplus/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly ILogger<SettingsController> _logger;

        private readonly ISettingsRepository _settingRepo;

        public SettingsController(ILogger<SettingsController> logger, ISettingsRepository settingRepo)
        {
            _logger = logger;
            _settingRepo = settingRepo;
        }

        [HttpPost]
        [Route("get_customer_type")]
        public async Task<IActionResult> Getcustomertype()
        {
            try
            {
                return Ok("get_customer_type");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

    }

}
