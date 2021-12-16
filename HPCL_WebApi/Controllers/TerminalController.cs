using HPCL.DataModel.Terminal;
using HPCL.DataRepository.Terminal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/terminal")]
    public class TerminalController : ControllerBase
    {
        private readonly ILogger<TerminalController> _logger;

        private readonly ITerminalRepository _terminalRepo;

        public TerminalController(ILogger<TerminalController> logger, ITerminalRepository terminalRepo)
        {
            _logger = logger;
            _terminalRepo = terminalRepo;
        }

        [HttpPost]
        [Route("generate_batch_no")]
        public async Task<IActionResult> Generatebatchno()
        {
            try
            {
                return Ok("get_transaction_detail_by_customerid_cardno_mobileno");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

    }
   
}
