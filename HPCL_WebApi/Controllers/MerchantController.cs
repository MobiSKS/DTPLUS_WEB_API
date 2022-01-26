using HPCL.DataModel.Merchant;
using HPCL.DataRepository.Merchant;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/merchant")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly ILogger<HQController> _logger;

        private readonly IMerchantRepository _merchant;
        public MerchantController(ILogger<HQController> logger, IMerchantRepository merchant)
        {
            _logger = logger;
            _merchant = merchant;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_merchant_type")]
        public async Task<IActionResult> GetMerchantType([FromBody] GetMerchantTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _merchant.GetMerchantType(ObjClass);
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
        [Route("get_outlet_category")]
        public async Task<IActionResult> GetOutletCategory([FromBody] GetMerchantOutletCategoryModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _merchant.GetOutletCategory(ObjClass);
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
        [Route("get_sbu")]
        public async Task<IActionResult> GetSBU([FromBody] MerchantGetSBUModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _merchant.GetSBU(ObjClass);
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
