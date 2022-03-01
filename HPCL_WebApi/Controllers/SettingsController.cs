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
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_zone_for_location_mapping")]
        public async Task<IActionResult> GetZone([FromBody] SettingGetZoneModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetZone(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_region_for_location_mapping")]
        public async Task<IActionResult> GetRegion([FromBody] SettingGetRegionModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetRegion(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_sales_area")]
        public async Task<IActionResult> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetSalesarea(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_transaction_type")]
        public async Task<IActionResult> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetTransactionType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_country")]
        public async Task<IActionResult> GetCountry([FromBody] SettingGetCountryModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCountry(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_state")]
        public async Task<IActionResult> GetState([FromBody] SettingGetStateModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetState(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_role")]
        public async Task<IActionResult> GetRole([FromBody] SettingGetRoleModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetRole(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_product")]
        public async Task<IActionResult> GetProduct([FromBody] SettingGetProductModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetProduct(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_entity")]
        public async Task<IActionResult> GetEntity([FromBody] SettingGetEntityModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetEntity(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_entity_status_type")]
        public async Task<IActionResult> GetEntityStatusType([FromBody] SettingGetEntityTypesModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetEntityStatusType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_city")]
        public async Task<IActionResult> GetCity([FromBody] SettingGetCityModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass,null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetCity(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass,null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass,result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_district")]
        public async Task<IActionResult> GetDistrict([FromBody] SettingGetDistrictModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetDistrict(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_proof_type")]
        public async Task<IActionResult> GetProofType([FromBody] SettingGetProofTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetProofType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_tier")]
        public async Task<IActionResult> GetTier([FromBody] SettingGetTierModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _settingRepo.GetTier(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    return this.OkCustom(ObjClass, result, _logger);
                }
            }

        }


    }

}
