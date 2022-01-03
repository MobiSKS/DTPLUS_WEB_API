

namespace HPCL_WebApi.ExtensionMethod
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public static class ControllerBaseExtension
    {

        public static IActionResult OkCustom(this ControllerBase controller )
        {

            return controller.Ok ();

        }
        public static IActionResult BadRequestCustom(this ControllerBase controller)
        {

            return controller.BadRequest();

        }
        public static IActionResult NotFoundCustom(this ControllerBase controller)
        {

            return controller.NotFound();

        }
    }
}
