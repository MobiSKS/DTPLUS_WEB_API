using HPCL.DataRepository.Account;
using HPCL.DataRepository.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

namespace HPCL_WebApi.Controllers
{

    [Route("api/dtplus/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepo;
        private readonly ILogger<LoginController> _logger;
        public LoginController(ILoginRepository loginRepo, ILogger<LoginController> logger)
        {
            _loginRepo = loginRepo;
            _logger = logger;
        }


        [HttpPost]
        [Route("get_user_login")]
        public async Task<IActionResult> GetUserLogin()
        {


            try
            {
                return Ok("GetUserLogin");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("get_dashbord_data")]
        public async Task<IActionResult> GetDashbordData()
        {


            try
            {
                return Ok("GetDashbordData");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("forgot_password")]
        public async Task<IActionResult> ForgotPassword()
        {


            try
            {
                return Ok("ForgotPassword");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("change_password")]
        public async Task<IActionResult> ChangePassword()
        {


            try
            {
                return Ok("ChangePassword");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("validate_pin")]
        public async Task<IActionResult> ValidatePin()
        {


            try
            {
                return Ok("ValidatePin");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("send_otp")]
        public async Task<IActionResult> SendOtp()
        {


            try
            {
                return Ok("SendOtp");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate()
        {


            try
            {
                return Ok("Authenticate");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("set_all_configurations_for_terminal")]
        public async Task<IActionResult> SetAllConfigurationsForTerminal()
        {


            try
            {
                return Ok("SetAllConfigurationsForTerminal");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("create_feedback_question_list")]
        public async Task<IActionResult> CreateFeedbackQuestionList()
        {


            try
            {
                return Ok("CreateFeedbackQuestionList");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("get_feedback_questionList")]
        public async Task<IActionResult> GetFeedbackQuestionList()
        {


            try
            {
                return Ok("CreateFeedbackQuestionList");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
       
        [HttpPost]
        [Route("save_feedback_form")]
        public async Task<IActionResult> SaveFeedbackForm()
        {


            try
            {
                return Ok("SaveFeedbackForm");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("create_feedback_response_list")]
        public async Task<IActionResult> CreateFeedbackResponseList()
        {


            try
            {
                return Ok("CreateFeedbackResponseList");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("get_feedback_response_detail")]
        public async Task<IActionResult> GetFeedbackResponseDetail()
        {


            try
            {
                return Ok("GetFeedbackResponseDetail");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


    }
}
