using HPCL.DataModel.Settings;
using HPCL.DataRepository.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using System.Collections.Generic;
using System.Linq;

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
                    List<SettingGetSalesareaModelOutput> item = result.Cast<SettingGetSalesareaModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetTransactionTypeModelOutput> item = result.Cast<SettingGetTransactionTypeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetRoleModelOutput> item = result.Cast<SettingGetRoleModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetProductModelOutput> item = result.Cast<SettingGetProductModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetEntityModelOutput> item = result.Cast<SettingGetEntityModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetEntityTypesModelOutput> item = result.Cast<SettingGetEntityTypesModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetProofTypeModelOutput> item = result.Cast<SettingGetProofTypeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
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
                    List<SettingGetTierModelOutput> item = result.Cast<SettingGetTierModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


    }

}
