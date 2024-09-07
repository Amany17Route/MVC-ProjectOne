namespace MVC_Project01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // app.MapGet("/Home", () => "Hello World!");
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("Hello From Home");
                });

                endpoints.MapPost("/Products", async context =>
                {
                    await context.Response.WriteAsync("Hello From Products");
                });
        
            });
  app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Request  Page Is Not Found"); });
            app.Run();

    
        }
    }
}
