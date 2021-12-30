using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using HPCL.DataRepository.Officer;

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
        
    }

}
