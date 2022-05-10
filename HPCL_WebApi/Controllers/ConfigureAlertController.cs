using HPCL.DataRepository.ConfigureAlert;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HPCL_WebApi.Controllers
{
    public class ConfigureAlertController : Controller
    {
        private readonly ILogger<ConfigureAlertController> _logger;

        private readonly IConfigureAlertRepository _ALRepo;
        public ConfigureAlertController(ILogger<ConfigureAlertController> logger, IConfigureAlertRepository ALRepo)
        {
            _logger = logger;
            _ALRepo = ALRepo;
        }
    }
}
