using HPCL.DataModel.Transaction;
using HPCL.DataRepository.Transaction;
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
    [Route("/api/dtplus/transaction")]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;

        private readonly ITransactionRepository _transactionRepo;

        public TransactionController(ILogger<TransactionController> logger, ITransactionRepository transactionRepo)
        {
            _logger = logger;
            _transactionRepo = transactionRepo;
        }

        [HttpPost]
        [Route("get_transaction_detail_by_customerid_cardno_mobileno")]
        public async Task<IActionResult> Getransactiondetailbycustomeridcardnomobileno()
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
