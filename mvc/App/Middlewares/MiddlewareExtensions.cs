namespace App.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseBasicMiddleware(this WebApplication app)
        {
            return app.UseMiddleware<BasicMiddleware>();
        }
    }
}