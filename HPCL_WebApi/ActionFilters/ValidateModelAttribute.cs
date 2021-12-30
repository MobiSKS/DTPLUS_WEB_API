using HPCL.Infrastructure.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HPCL_WebApi.ActionFilters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new JsonResult
                 (
                 new RouteValueDictionary(new BadRequestFailureResult(context).Execute()
                 ));
                // context.Result = new BadRequestObjectResult(context.ModelState);
            }
            base.OnActionExecuting(context);
        }
        public class BadRequestFailureResult 
        {
            ActionExecutingContext _context;
           
            public BadRequestFailureResult(ActionExecutingContext context)
            {
                _context = context;
            }

            public ApiResponseMessage Execute()
            {
                HttpRequest request = _context.HttpContext.Request;
                var descriptor = _context.ActionDescriptor as ControllerActionDescriptor;
                var actionName = descriptor.ActionName;
                var modelState = _context.ModelState.Values;
                var allErrors = _context.ModelState.Values.SelectMany(v => v.Errors);
                ApiResponseMessage response = new ApiResponseMessage
                {
                    Status_Code = (int)HttpStatusCode.BadRequest,
                    Message = "Error",
                    Success = false,
                    Method_Name = actionName,
                    Data = string.Join(" - ", allErrors.Select(e => e.ErrorMessage)),
                    Model_State = null
                };
                return (response);

            }


        }

    }
}
