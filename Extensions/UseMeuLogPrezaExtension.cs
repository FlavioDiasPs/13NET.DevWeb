using Aula01.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.Extensions
{
    public static class UseMeuLogPrezaExtension
    {
        public static IApplicationBuilder UseMeuLogPreza(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
