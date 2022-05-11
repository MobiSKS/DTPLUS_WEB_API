using HPCL.DataModel.ConfigureAlert;
using HPCL.DataRepository.ConfigureAlert;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/configure")]
    [ApiController]
    public class ConfigureAlertController : ControllerBase
    {
        private readonly ILogger<ConfigureAlertController> _logger;

        private readonly IConfigureAlertRepository _ALRepo;
        public ConfigureAlertController(ILogger<ConfigureAlertController> logger, IConfigureAlertRepository ALRepo)
        {
            _logger = logger;
            _ALRepo = ALRepo;
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_sms_alert_for_multiple_mobile_detail")]
        public async Task<IActionResult> GetSmsAlertForMultipleMobileDetail([FromBody] GetSmsAlertForMultipleMobileDetailModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.GetSmsAlertForMultipleMobile(ObjClass);
                if (result == null || result.CustomerDetail.Count == 0)
                {
                    return this.Fail(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }
        }


            [HttpPost]
            [ServiceFilter(typeof(CustomAuthenticationFilter))]
            [Route("update_sms_alert_for_multiple_mobiledetail")]
            public async Task<IActionResult> UpdateSmsAlertForMultipleMobileDetail([FromBody] UpdateSmsAlertForMultipleMobileDetailModelinput ObjClass)
            {

                if (ObjClass == null)
                {
                    return this.BadRequestCustom(ObjClass, null, _logger);
                }
                else
                {
                    var result = await _ALRepo.UpdateSmsAlertForMultipleMobileDetail(ObjClass);
                    if (result == null)
                    {
                        return this.NotFoundCustom(ObjClass, null, _logger);
                    }
                    else
                    {
                        if (result.Cast<UpdateSmsAlertForMultipleMobileDetailModelOutput>().ToList()[0].Status == 1)
                        {
                            return this.OkCustom(ObjClass, result, _logger);
                        }
                        else
                        {
                            return this.FailCustom(ObjClass, result, _logger,
                                result.Cast<UpdateSmsAlertForMultipleMobileDetailModelOutput>().ToList()[0].Reason);
                        }
                    }
                }
            }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("delete_sms_alert_for_multiple_mobiledetail")]
        public async Task<IActionResult> DeleteSmsAlertForMultipleMobileDetail([FromBody] DeleteSmsAlertForMultipleMobileDetailModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ALRepo.DeleteSmsAlertForMultipleMobileDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<DeleteSmsAlertForMultipleMobileDetailModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<DeleteSmsAlertForMultipleMobileDetailModelOutput>().ToList()[0].Reason);
                    }


                }
            }
        }



    }
}
