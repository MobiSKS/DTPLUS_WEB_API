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
    public class CustomerAPIController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;
        private readonly ICustomerAPIRepository _custApiRepo;

        public CustomerAPIController(ILogger<CardController> logger, ICustomerAPIRepository customerApiRepo)
        {
            _logger = logger;
            _custApiRepo = customerApiRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomerAPIAuthenticationFilter))]
        [Route("customerapi_check_vechile_no")]
        public async Task<IActionResult> CustomerAPICheckVechileNo([FromBody] CustomerAPICheckVechileNoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _custApiRepo.CustomerAPICheckVechileNo(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<CustomerAPICheckVechileNoModelOutput> item = result.Cast<CustomerAPICheckVechileNoModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
    }
}
