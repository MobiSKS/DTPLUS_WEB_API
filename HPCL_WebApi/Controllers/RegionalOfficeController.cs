using HPCL.DataModel.RegionalOffice;
using HPCL.DataRepository.RegionalOffice;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/regionaloffice")]
    [ApiController]
    public class RegionalOfficeController : ControllerBase
    {
        private readonly ILogger<RegionalOfficeController> _logger;

        private readonly IRegionalOfficeRepository _RORepo;
        public RegionalOfficeController(ILogger<RegionalOfficeController> logger, IRegionalOfficeRepository RORepo)
        {
            _logger = logger;
            _RORepo = RORepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_regional_office")]
        public async Task<IActionResult> GetRegionalOffice([FromBody] GetRegionalOfficeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RORepo.GetRegionalOffice(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetRegionalOfficeModelOutput> item = result.Cast<GetRegionalOfficeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }
    }
}
