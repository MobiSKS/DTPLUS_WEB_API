using HPCL.DataModel.Transaction;
using HPCL.DataRepository.Transaction;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/transaction")]
    
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;

        private readonly ITransactionRepository _transRepo;

        public TransactionController(ILogger<TransactionController> logger, ITransactionRepository transRepo)
        {
            _logger = logger;
            _transRepo = transRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("sale_by_terminal")]
        public async Task<IActionResult> SaleByTerminal([FromBody] TransactionSalebyTerminalModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.SaleByTerminal(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<TransactionSalebyTerminalModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<TransactionSalebyTerminalModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("recharge_ccms_account")]
        public async Task<IActionResult> RechargeCCMSAccount([FromBody] RechargeCCMSAccountModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.RechargeCCMSAccount(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<RechargeCCMSAccountModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<RechargeCCMSAccountModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_batch_no")]
        public async Task<IActionResult> GetBatchno([FromBody] GetBatchnoModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _transRepo.GetBatchno(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<GetBatchnoModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<GetBatchnoModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }
    }
}
