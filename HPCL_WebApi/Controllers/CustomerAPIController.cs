using HPCL.DataModel.CustomerAPI;
using HPCL.DataRepository.CustomerAPI;
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
    [Route("/api/CustomerInterface/CustomerAPI")]
    [ServiceFilter(typeof(CustomerAPIAuthenticationFilter))]
    public class CustomerAPIController : ControllerBase
    {
        private readonly ILogger<CustomerAPIController> _logger;
        private readonly ICustomerAPIRepository _custApiRepo;

        public CustomerAPIController(ILogger<CustomerAPIController> logger, ICustomerAPIRepository customerApiRepo)
        {
            _logger = logger;
            _custApiRepo = customerApiRepo;
        }

        [HttpPost]
        [Route("customerapi_check_vechile_no")]
        public async Task<IActionResult> CustomerAPICheckVechileNo([FromBody] CustomerAPICheckVechileNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.CustomerAPIBadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _custApiRepo.CustomerAPICheckVechileNo(ObjClass);
                if (result == null)
                {
                    return this.CustomerAPINotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CustomerAPICheckVechileNoModelOutput> item = result.Cast<CustomerAPICheckVechileNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.CustomerAPIOkCustom(ObjClass, result, _logger);
                    else
                        return this.CustomerAPIFail(ObjClass, result, _logger);
                }
            }
        }
    }
}
