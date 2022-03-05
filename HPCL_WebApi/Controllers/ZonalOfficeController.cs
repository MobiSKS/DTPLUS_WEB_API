using HPCL.DataModel.ZonalOffice;
using HPCL.DataRepository.ZonalOffice;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/zonaloffice")]
    [ApiController]
    public class ZonalOfficeController : ControllerBase
    {
        private readonly ILogger<ZonalOfficeController> _logger;

        private readonly IZonalOfficeRepository _ZORepo;
        public ZonalOfficeController(ILogger<ZonalOfficeController> logger, IZonalOfficeRepository ZORepo)
        {
            _logger = logger;
            _ZORepo = ZORepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_zonal_office")]
        public async Task<IActionResult> GetZonalOffice([FromBody] GetZonalOfficeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _ZORepo.GetZonalOffice(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetZonalOfficeModelOutput> item = result.Cast<GetZonalOfficeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }
    }

}
