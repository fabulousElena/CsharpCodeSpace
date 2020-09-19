using Microsoft.AspNetCore.Builder;

namespace CoreDemo02
{
    public static class CustomMiddlewareExtension
    {
        //封装一下
        public static IApplicationBuilder UseTest(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TestMiddleware>();
        }
    }
}
