using HPCL.DataModel.CountryZone;
using HPCL.DataRepository.CountryZone;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/countryzone")]
    [ApiController]
    public class CountryZoneController : ControllerBase
    {
        private readonly ILogger<CountryZoneController> _logger;

        private readonly ICountryZoneRepository _CZRepo;
        public CountryZoneController(ILogger<CountryZoneController> logger, ICountryZoneRepository CZRepo)
        {
            _logger = logger;
            _CZRepo = CZRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_country_zone")]
        public async Task<IActionResult> GetCountryZone([FromBody] GetCountryZoneModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _CZRepo.GetCountryZone(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCountryZoneModelOutput> item = result.Cast<GetCountryZoneModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }
    }

}
