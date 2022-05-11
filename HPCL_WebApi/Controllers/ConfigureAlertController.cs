using HPCL.DataModel.ConfigureAlert;
using HPCL.DataRepository.ConfigureAlert;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/configure")]
    [ApiController]
    public class ConfigureAlertController : ControllerBase
    {
        private readonly ILogger<ConfigureAlertController> _logger;

        private readonly IConfigureAlertRepository _CALRepo;
        public ConfigureAlertController(ILogger<ConfigureAlertController> logger, IConfigureAlertRepository CALRepo)
        {
            _logger = logger;
            _CALRepo = CALRepo;
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
                var result = await _CALRepo.GetSmsAlertForMultipleMobile(ObjClass);
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
                var result = await _CALRepo.UpdateSmsAlertForMultipleMobileDetail(ObjClass);
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
                var result = await _CALRepo.DeleteSmsAlertForMultipleMobileDetail(ObjClass);
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


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_configure_sms_alerts_details_by_customerid")]
        public async Task<IActionResult> GetConfigureSMSAlertsDetailsByCustomerID([FromBody] ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _CALRepo.GetConfigureSMSAlertsDetailsByCustomerID(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelOutput> item = result.Cast<ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }




        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_configure_sms_alerts")]
        public async Task<IActionResult> UpdateConfigureSMSAlerts([FromBody] UpdateConfigureSMSAlertsModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _CALRepo.UpdateConfigureSMSAlerts(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateConfigureSMSAlertsModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateConfigureSMSAlertsModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_configure_email_alerts")]
        public async Task<IActionResult> GetConfigureEmailAlerts([FromBody] GetConfigureEmailAlertsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _CALRepo.GetConfigureEmailAlerts(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetConfigureEmailAlertsOutput> item = result.Cast<GetConfigureEmailAlertsOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_configure_email_alert")]
        public async Task<IActionResult> UpdateConfigureEmailAlert([FromBody] UpdateConfigureEmailAlertModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _CALRepo.UpdateConfigureEmailAlert(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<UpdateConfigureEmailAlertModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<UpdateConfigureEmailAlertModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }



    }
}
