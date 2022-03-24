using HPCL.DataModel.RBE;
using HPCL.DataRepository.RBE;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/RBE")]
    [ApiController]
    public class RBEController : ControllerBase
    {
        private readonly ILogger<RBEController> _logger;

        private readonly IRBERepository _RBERepo;
        public RBEController(ILogger<RBEController> logger, IRBERepository RBERepo)
        {
            _logger = logger;
            _RBERepo = RBERepo;
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("change_rbe_mapping_model")]
        public async Task<IActionResult> ChangeRBEMappingModel([FromBody] ChangeRBEMappingModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.ChangeRBEMappingModel(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ChangeRBEMappingModelOutput> item = result.Cast<ChangeRBEMappingModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("manage_rbe_user")]
        public async Task<IActionResult> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _RBERepo.ManageRBEUser(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<ManageRBEUserModelOutput> item = result.Cast<ManageRBEUserModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
    }
}
