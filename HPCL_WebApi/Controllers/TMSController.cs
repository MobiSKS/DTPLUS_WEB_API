﻿using Microsoft.AspNetCore.Mvc;
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
using HPCL.Infrastructure.CommonClass;

namespace HPCL_WebApi.Controllers
{
    [ApiController]
    [Route("/api/dtplus/TMS")]
    public class TMSController : Controller
    {
        private readonly ILogger<TMSController> _logger;

        private readonly ITMSRepository _tmsRepo;
        private readonly IConfiguration _configuration;
        public TMSController(ILogger<TMSController> logger, ITMSRepository tmsRepo, IConfiguration configuration)
        {
            _logger = logger;
            _tmsRepo = tmsRepo;
            _configuration = configuration;
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_enroll_transport_management_system")]
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
                    if (result.Cast<GetEnrollTransportManagementSystemModelOutput>().ToList()[0].Status == 1)
                    {
                        ApiRequestResponse response = new ApiRequestResponse();
                        CargoFlLoginResponse cargoFlLoginResponse = new CargoFlLoginResponse(); 
                        CargoFlLogin obj = new CargoFlLogin() { cargofl_userid = _configuration.GetSection("TMSSettings:CargoFLUser").Value};
                       // string cargofl_userid = "admin";
                        string apiurl = _configuration.GetSection("TMSSettings:APIUrl").Value;                          

                        string json = Variables.CallPostAPI(apiurl+ "v1/common/loginSuperUser", JsonConvert.SerializeObject(obj), "").Result;
                       if(!string.IsNullOrEmpty(json))
                        {
                            cargoFlLoginResponse=JsonConvert.DeserializeObject<CargoFlLoginResponse>(json);
                        }
                        var dat = JObject.Parse(json);

                        response.apiurl = apiurl + "v1/common/loginSuperUser";
                        response.request = JsonConvert.SerializeObject(obj);
                        response.response = json;
                        response.UserId = "Test";
                        _tmsRepo.InsertAPIRequestResponse(response);

                        CargoFlRegisterTrucker objcargoFL = new CargoFlRegisterTrucker();
                        var cargoflUser = _tmsRepo.GetCargoFlRegisterTruckerDetail(ObjClass.CustomerId).Result.ToList<CargoFlRegisterTrucker>();
                        if (cargoflUser != null && cargoflUser.Count > 0)
                        {
                            objcargoFL = cargoflUser.ToList().FirstOrDefault();
                        }
                       string res = Variables.CallPostAPI(apiurl+ "v1/user/registerTrucker", JsonConvert.SerializeObject(objcargoFL), cargoFlLoginResponse.access_token).Result;
                       
                        response.apiurl = apiurl + "v1/user/registerTrucker";
                        response.request = JsonConvert.SerializeObject(obj);                   


                            response.response = res;
                        if (string.IsNullOrEmpty(res))
                        {
                            CargoFlLogin objval = new CargoFlLogin();
                            objval = JsonConvert.DeserializeObject<CargoFlLogin>(res);

                            response.TMSUserId = objval.cargofl_userid;
                            response.CustomerId = ObjClass.CustomerId;
                            response.TMSStatus = 1;

                        }

                            _tmsRepo.InsertAPIRequestResponse(response);
                        return this.OkCustom(ObjClass, JObject.Parse(res), _logger);
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

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Get_Customer_Detail_For_Enrollment_Approval")]
        public async Task<IActionResult> GetCustomerDetailForEnrollmentApproval([FromBody] GetCustomerDetailForEnrollmentApprovalInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetCustomerDetailForEnrollmentApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCustomerDetailForEnrollmentApprovalOutput> item = result.Cast<GetCustomerDetailForEnrollmentApprovalOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Get_TMSEnrollment_Status")]
        public async Task<IActionResult> GetEnrollmentStatusDetail(GetEnrollmentStatusModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {

                var result = await _tmsRepo.GetEnrollmentStatus();
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
        [Route("Update_TMS_Enrollment_TMS_Status")]
        public async Task<IActionResult> UpdateTMSEnrollmentTMSStatus([FromBody] TMSUpdateEnrollmentStatusModelInput ObjClass)
        {
            
            string apiurl = _configuration.GetSection("TMSSettings:APIUrl").Value;

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.TMSInsertCustomerTracking(ObjClass, apiurl);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {                    
                        return this.OkCustom(ObjClass, result, _logger);
                   
                }
            }

        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Get_Vehicle_Enrollment_Detail")]
        public async Task<IActionResult> GetEnrollVehicleManagementDetail([FromBody] GetEnrollVehicleManagementModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetEnrollVehicleManagementDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetCustomerDetailForEnrollmentApprovalOutput> item = result.Cast<GetCustomerDetailForEnrollmentApprovalOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Get_Vehicle_Enrollment_Status")]
        public async Task<IActionResult> GetEnrollVehicleManagementStatus([FromBody] GetEnrollVehicleManagementStatusInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.GetEnrollVehicleManagementStatus();
                if (result == null)
                {
                    return this.NotFoundCustom(null, null, _logger);
                }
                else
                {
                    List<GetEnrollVehicleManagementStatusOutput> item = result.Cast<GetEnrollVehicleManagementStatusOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(null, result, _logger);
                    else
                        return this.Fail(null, result, _logger);
                }
            }
            
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("Insert_Vehicle_Enrollment_Status")]
        public async Task<IActionResult> InsertVehicleEnrollmentStatus([FromBody] InsertVehicleEnrollmentStatusInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.InsertVehicleEnrollmentStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(null, null, _logger);
                }
                else
                {
                    List<InsertVehicleEnrollmentStatusOutput> item = result.Cast<InsertVehicleEnrollmentStatusOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(null, result, _logger);
                    else
                        return this.Fail(null, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("bind_enroll_transport_management_system")]
        public async Task<IActionResult> BindEnrollTransportManagementSystem([FromBody] BindEnrollTransportManagementSystemModelInput ObjClass)
        {
            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _tmsRepo.BindEnrollTransportManagementSystem(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<BindEnrollTransportManagementSystemModelOutput> item = result.Cast<BindEnrollTransportManagementSystemModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }
        }
    }

    
}
