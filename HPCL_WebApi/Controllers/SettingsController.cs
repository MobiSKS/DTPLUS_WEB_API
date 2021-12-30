using HPCL.DataModel.Settings;
using HPCL.DataRepository.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;

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
        [CustomAuthenticationFilter]
        [Route("get_customer_type")]
        public async Task<IActionResult> GetCustomerType([FromBody] SettingGetCustomerTypeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCustomerType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }
        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_customer_sub_type")]
        public async Task<IActionResult> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCustomerSubType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }
        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_hq")]
        public async Task<IActionResult> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {

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
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }


        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_zone")]
        public async Task<IActionResult> GetZone([FromBody] SettingGetZoneModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetZone(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_region")]
        public async Task<IActionResult> GetRegion([FromBody] SettingGetRegionModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetRegion(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_sales_area")]
        public async Task<IActionResult> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetSalesarea(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_transaction_type")]
        public async Task<IActionResult> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetTransactionType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_store_categories")]
        public async Task<IActionResult> GetStoreCategories([FromBody] SettingGetStoreCategoriesModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetStoreCategories(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_country")]
        public async Task<IActionResult> GetCountry([FromBody] SettingGetCountryModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCountry(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_state")]
        public async Task<IActionResult> GetState([FromBody] SettingGetStateModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetState(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_sbu")]
        public async Task<IActionResult> GetSBU([FromBody] SettingGetSBUModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetSBU(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_role")]
        public async Task<IActionResult> GetRole([FromBody] SettingGetRoleModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetRole(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_product")]
        public async Task<IActionResult> GetProduct([FromBody] SettingGetProductModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetProduct(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_entity_types")]
        public async Task<IActionResult> GetEntityTypes([FromBody] SettingGetEntityTypesModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetEntityTypes(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_officer_type")]
        public async Task<IActionResult> GetOfficerType([FromBody] SettingGetOfficerTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetOfficerType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("get_officer_type")]
        public async Task<IActionResult> GetCity([FromBody] SettingGetCityModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCity(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, _logger);
                }
                else
                {
                    return this.OkCustom(result, _logger);
                }
            }

        }
    }

}
