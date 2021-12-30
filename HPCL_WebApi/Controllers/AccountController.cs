using HPCL.DataRepository.Account;
using HPCL.Infrastructure.CommonClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Extensions;
using System;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
using HPCL.Infrastructure.TokenManager;
using Microsoft.Extensions.Configuration;
using HPCL_WebApi.ExtensionMethod;
namespace HPCL_WebApi.Controllers
{

    [Route("api/dtplus")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly Variables ObjVariable;
        private readonly IAccountRepository _accountRepo;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountRepository accountRepo, ILogger<AccountController> logger, IConfiguration configuration)
        {
            _accountRepo = accountRepo;
            _logger = logger;
            ObjVariable = new Variables(configuration);
        }



        [HttpPost]
        [Route("generatetoken")]
        public IActionResult GenerateToken(GenerateTokenInput ObjClass)
        {
            //ReturnGenerateTokenStatusOutput TokenObject = new ReturnGenerateTokenStatusOutput();
            string MethodName = "GENERATE_TOKEN";
            try
            {
                StatusInformation.API_Key_Is_Null.GetDisplayName();
                var request = Request;
                var headers = request.Headers;
                string API_Key = string.Empty;
                string Secret_Key = string.Empty;
                byte[] bytes = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 };
                string SecretKey = Convert.ToBase64String(bytes);
                bool IsResult = TokenManager.Return_Key(Request, ObjVariable, _accountRepo, out string UserMessage, 0, out int IntStatusCode, ObjClass.Useragent, ObjClass.Userip, MethodName, ObjClass.Userid);

                if (IsResult == true)
                {
                    TokenManager.Secret = SecretKey;
                    return this.OkToken(_logger, ObjClass, MethodName);

                }
                else
                {
                    TokenManager.Secret = SecretKey;
                    return this.BadRequestToken(_logger, MethodName);
                }
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }

        }
    }
}
