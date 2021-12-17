using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Description;
using IOperationFilter = Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter;

namespace HPCL.Infrastructure.Swagger
{

    public class AuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Description = "access token",
                    Required = false,
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                        Default = new OpenApiString("Bearer ")
                    }
                   

                });
                operation.Parameters.Add(new OpenApiParameter
                {

                    Name = "API_Key",
                    In = ParameterLocation.Header,
                    Description = "API_Key",
                    Required = false,
                    Schema = new OpenApiSchema
                    {
                        Type = "string"
                    }

                   
                }
                );

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Secret_Key",
                    In = ParameterLocation.Header,
                    Description = "Secret_Key",
                    Required = false,
                    Schema = new OpenApiSchema
                    {
                        Type = "string"
                    }
                  
                }
                );
           
        }
    }

}
