using HPCL.DataModel.Settings;
using HPCL.DataRepository.Settings;
using HPCL.Infrastructure.Response;
using HPCL_WebApi.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

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
        [CustomAuthenticationFilter]
        [Route("get_hq")]
        public async Task<IActionResult> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {
            try
            {
                response = new ApiResponseMessage();

                if (ObjClass == null)
                {
                    response.Message = StatusInformation.Request_JSON_Body_Is_Null.ToString();
                    response.Success = false;
                    response.Status_Code = BadRequest().StatusCode;
                    response.Data = null;
                    _logger.LogInformation(response.Method_Name + ":" + response.Message);
                    return BadRequest(response);
                }
                else
                {
                    var result = await _settingRepo.GetHQ(ObjClass);
                    if (result == null)
                    {
                        response.Message = StatusInformation.Fail.ToString();
                        response.Success = false;
                        response.Status_Code = NotFound().StatusCode;
                        response.Data = null;
                        _logger.LogInformation(response.Method_Name + ":" + response.Message);
                        return NotFound(response);
                    }

                    var output = new SettingGetHQModelOutput()
                    {
                        HQID = result.HQID,
                        HQName = result.HQName,
                        HQShortName = result.HQShortName
                    };

                    response.Message = StatusInformation.Success.ToString();
                    response.Success = true;
                    response.Status_Code = Ok().StatusCode;
                    response.Data = output;
                    _logger.LogInformation(response.Method_Name + ":" + response.Message);
                    return Ok(response);
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
