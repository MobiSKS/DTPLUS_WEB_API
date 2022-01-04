using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using HPCL.DataRepository.Officer;
using HPCL.DataModel.Officer;
using System.Linq;
using HPCL.Infrastructure.CommonClass;

namespace HPCL_WebApi.Controllers
{

    [ApiController]
    [Route("/api/dtplus/officer")]
    public class OfficerController : ControllerBase
    {
        private readonly ILogger<OfficerController> _logger;

        private readonly IOfficerRepository _officerRepo;
        public OfficerController(ILogger<OfficerController> logger, IOfficerRepository officerRepo)
        {
            _logger = logger;
            _officerRepo = officerRepo;
        }

        [HttpPost]
        [CustomAuthenticationFilter]
        [Route("insert_officer")]
        public async Task<IActionResult> InsertOfficer([FromBody] OfficerInsertModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _officerRepo.InsertOfficer(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<OfficerInsertModelOutput>().ToList()[0].Status == 1)
                    {
                        Variables.FunSendMail(ObjClass.EmailId, "Your Password is: " + result.Cast<OfficerInsertModelOutput>().ToList()[0].Password + "", "Password Details");
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger, result.Cast<OfficerInsertModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        //[CustomAuthenticationFilter]
        [Route("get_officer_detail")]
        public async Task<IActionResult> GetOfficerDetail([FromBody] GetOfficerModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _officerRepo.GetOfficerDetail(ObjClass);
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
