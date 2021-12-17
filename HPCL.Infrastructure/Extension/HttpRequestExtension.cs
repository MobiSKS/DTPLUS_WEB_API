using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPCL.Infrastructure.Extension
{
    public static class HttpRequestExtension
    {
        public static string GetHeader(this HttpRequest request, string key)
        {
            StringValues value = string.Empty;
            request.Headers.TryGetValue(key, out value);
            return value.ToString ();

        }
    }
}
