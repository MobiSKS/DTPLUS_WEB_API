using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using HPCL_WebApi.ExtensionMethod;
using HPCL_WebApi.ActionFilters;
using HPCL.DataModel.TMS;
using System.Linq;
using HPCL.DataRepository.TMS;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using static HPCL_WebApi.ActionFilters.CustomAuthenticationFilter;
using Microsoft.AspNetCore.Routing;
using System;
using System.IO;
using System.Text;
using System.Net.Http.Headers;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/TMS")]
    public class TMSController : Controller
    {
        private readonly ILogger<TMSController> _logger;

        private readonly ITMSRepository _tmsRepo;
        public TMSController(ILogger<TMSController> logger, ITMSRepository tmsRepo)
        {
            _logger = logger;
            _tmsRepo = tmsRepo;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_Enroll_transport_management_system")]
        public async Task<IActionResult> GetEnrollTransportManagementSystem([FromBody] GetEnrollTransportManagementSystemModelInput ObjClass)
        {
          

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetEnrollTransportManagementSystem(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    //IConfiguration _configuration;
                    //string APIUrl;
                    if (result.Cast<GetEnrollTransportManagementSystemModelOutput>().ToList()[0].Status == 1)
                    {
                        //APIUrl = configuration.GetSection("TokenSettings:APIUrl").Value;
                        //_configuration = configuration;
                        //string[] scopes = new string[] { "user.read" };
                        //HttpClient client = new HttpClient();
                        //HttpResponseMessage response = client.GetAsync(APIUrl).Result;
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                        //string json = await client.GetStringAsync(APIUrl);
                        //if (response.IsSuccessStatusCode)
                        //{

                        //}
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {

                        return this.FailCustom(ObjClass, result, _logger,
                        result.Cast<GetEnrollTransportManagementSystemModelOutput>().ToList()[0].Reason);
                    }
                }
            }
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_enrollment_status")]
        public async Task<IActionResult> GetEnrollmentStatus([FromBody] GetEnrollmentStatusModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetEnrollmentStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetEnrollmentStatusModelOutput> item = result.Cast<GetEnrollmentStatusModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_enroll_vehicle")]
        public async Task<IActionResult> GetEnrollVehicle([FromBody] GetEnrollVehicleModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetEnrollVehicle(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjGetEnrollVehicle.Count > 0 && result.ObjGetEnrollVehicleCustomerName.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_manage_enrollments")]
        public async Task<IActionResult> GetManageEnrollments([FromBody] GetManageEnrollmentsModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetManageEnrollments(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetManageEnrollmentsModelOutput> item = result.Cast<GetManageEnrollmentsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

    }
}
