using Microsoft.AspNetCore.Builder;

namespace PROJECT.Infrastructure.Middlewares
{
    public static class GlobalExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseGlobalException(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlobalExceptionMiddleware>();
        }
    }
}
