using HPCL.DataModel.CountryRegion;
using HPCL.DataModel.Hotlist;
using HPCL.DataRepository.CountryRegion;
using HPCL.DataRepository.Hotlist;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/hotlist")]
    [ApiController]
    public class HotlistController : ControllerBase
    {
        private readonly ILogger<HotlistController> _logger;

        private readonly IHotlistRepository _HLRepo;
        public HotlistController(ILogger<HotlistController> logger, IHotlistRepository HLRepo)
        {
            _logger = logger;
            _HLRepo = HLRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_action_list")]
        public async Task<IActionResult> GetActionList([FromBody] GetActionListInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _HLRepo.GetActionList(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetActionListOutput> item = result.Cast<GetActionListOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_entity_type_list")]
        public async Task<IActionResult> GetEntityTypeList([FromBody] GetEntityTypeListInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _HLRepo.GetEntityTypeList(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetEntityTypeListOutput> item = result.Cast<GetEntityTypeListOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_reason_list_for_entities")]
        public async Task<IActionResult> GetReasonListForEntities([FromBody] GetReasonListForEntitiesInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _HLRepo.GetReasonListForEntities(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetReasonListForEntitiesOutput> item = result.Cast<GetReasonListForEntitiesOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

    }

}
