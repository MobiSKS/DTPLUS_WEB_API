﻿using HPCL.DataModel.District;
using HPCL.DataRepository.District;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/district")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly ILogger<DistrictController> _logger;

        private readonly IDistrictRepository _DstRepo;
        public DistrictController(ILogger<DistrictController> logger, IDistrictRepository DstRepo)
        {
            _logger = logger;
            _DstRepo = DstRepo;
        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_district")]
        public async Task<IActionResult> GetDistrict([FromBody] GetDistrictModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _DstRepo.GetDistrict(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<GetDistrictModelOutput> item = result.Cast<GetDistrictModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("delete_district")]
        public async Task<IActionResult> DeleteDistrict([FromBody] DeleteDistrictModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _DstRepo.DeleteDistrict(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<DeleteDistrictModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<DeleteDistrictModelOutput>().ToList()[0].Reason);
                    }
                }
            }

        }
    }

}