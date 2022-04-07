using HPCL.DataRepository.TMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/TMS")]
    public class TMSController : Controller
    {
        private readonly ILogger<TMSController> _logger;

        private readonly ITTMSRepository _tmsRepo;
        public TMSController(ILogger<TMSController> logger, ITTMSRepository tmsRepo)
        {
            _logger = logger;
            _tmsRepo = tmsRepo;
        }
    }
}
