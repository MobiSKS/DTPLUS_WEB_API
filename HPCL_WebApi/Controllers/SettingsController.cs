using HPCL.DataModel;
using HPCL.DataModel.Settings;
using HPCL.DataRepository.Settings;
using HPCL.Infrastructure.Response;
using HPCL_WebApi.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
using HPCL_WebApi.ExtensionMethod;
namespace HPCL_WebApi.Controllers
{

    [ApiController]
    [Route("/api/dtplus/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly ILogger<SettingsController> _logger;

        private readonly ISettingsRepository _settingRepo;
        ApiResponseMessage response;
        public SettingsController(ILogger<SettingsController> logger, ISettingsRepository settingRepo)
        {
            _logger = logger;
            _settingRepo = settingRepo;
        }

        [HttpPost]
        //[CustomAuthenticationFilter]
        [Route("get_hq")]
        public async Task<IActionResult> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {
            try
            {
                response = new ApiResponseMessage();
                
                if (ObjClass == null)
                {
                    return this.BadRequestCustom(null, _logger);
                }
                else
                {
                    var result = await _settingRepo.GetHQ(ObjClass);
                    if (result == null)
                    {
                        return this.NotFoundCustom(null, _logger);
                    }
                    var output = new SettingGetHQModelOutput()
                    {
                        HQID = result.HQID,
                        HQName = result.HQName,
                        HQShortName = result.HQShortName
                    };
                    return this.OkCustom(output, _logger);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(0, "Processing request from {Message}", ex.Message);
                return StatusCode(500, ex.Message);
            }
        }







    }

}
