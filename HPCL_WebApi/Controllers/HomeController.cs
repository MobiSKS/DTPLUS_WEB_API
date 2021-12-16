using HPCL.DataModel.Login;
using HPCL.DataRepository.Login;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static HPCL.Infrastructure.CommonClass.StatusMessage;

namespace HPCL_WebApi.Controllers
{
    //[Route("api/dtplus")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        // GET: Home
        private readonly ILoginRepository _loginRepo;

        public HomeController(ILoginRepository loginRepo)
        {
            _loginRepo = loginRepo;
        }

       // [HttpGet]
        //[CustomAuthenticationFilter]
        //[Route("/index")]
        //public async Task<Object> User_Login([FromBody] LoginModel ObjUser)
        public async Task<Object> Index()
        {
            LoginModel ObjUser = new LoginModel();
            //ObjUser.Useragent = "web";
            //ObjUser.Userid = "1";
            //ObjUser.Userip = "1";
            ObjUser.Mobileno = "982962934";


            try
            {
                if (ObjUser == null)
                {
                    return StatusCode(500, StatusInformation.Request_JSON_Body_Is_Null.ToString());
                }

                var user = await _loginRepo.User_Login(ObjUser);
                if (user == null)
                    return NotFound();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}