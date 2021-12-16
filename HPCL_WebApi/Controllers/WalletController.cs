using HPCL.DataModel.Wallet;
using HPCL.DataRepository.Wallet;
using HPCL.Infrastructure.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("api/dtplus/wallet")]
    public class WalletController : ControllerBase
    {
        private readonly ILogger<WalletController> _logger;

        private readonly IWalletRepository _walletRepo;

        private ApiResponseMessage response;
        public WalletController(ILogger<WalletController> logger, IWalletRepository walletRepo)
        {
            _logger = logger;
            _walletRepo = walletRepo;            
        }

        [HttpPost]
        [Route("set_sale_limits_of_cards")]
        public async Task<IActionResult> SetSaleLimitsOfCards()
        {
            try
            {
                return Ok("set_sale_limits_of_cards");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost]
        [Route("get_all_cards_by_customer_id")]
        public async Task<IActionResult> Getallcardsbycustomerid([FromBody] AllcardsbycustomeridInputModel ObjClass)
        {
            try
            {
                response = new ApiResponseMessage();

                if (ObjClass == null)
                {
                    response.Message = StatusInformation.Request_JSON_Body_Is_Null.ToString();
                    response.Success = false;
                    response.Status_Code = BadRequest().StatusCode;
                    response.Data = null;
                    return BadRequest(response);
                }
                else
                {
                    var result = await _walletRepo.Getallcardsbycustomerid(ObjClass);
                    if (result == null)
                    {
                        response.Message = StatusInformation.Fail.ToString();
                        response.Success = false;
                        response.Status_Code = NotFound().StatusCode;
                        response.Data = null;
                        return NotFound(response);
                    }

                    var output = new Allcardsbycustomerid()
                    {
                        Customer_Id = result.Customer_Id,
                        Customer_Name = result.Customer_Name,
                        ZO = result.ZO,
                        RO = result.RO,
                        Cardarr = result.Cardarr
                    };

                    response.Message = StatusInformation.Success.ToString();
                    response.Success = true;
                    response.Status_Code = Ok().StatusCode;
                    response.Data = output;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
