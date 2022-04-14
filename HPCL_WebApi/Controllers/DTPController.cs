using HPCL.DataModel.DTP;
using HPCL.DataRepository.DTP;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/dtp")]
    public class DTPController : ControllerBase
    {
        private readonly ILogger<DTPController> _logger;

        private readonly IDTPRepository _dtpRepo;

        public DTPController(ILogger<DTPController> logger, IDTPRepository dtpRepo)
        {
            _logger = logger;
            _dtpRepo = dtpRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_block_unblock_customer_ccms_account_by_customerid")]
        public async Task<IActionResult> GetMerchantType([FromBody] GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _dtpRepo.GetBlockUnBlockCustomerCCMSAccountByCustomerId(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput> item = result.Cast<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }
    }
}
