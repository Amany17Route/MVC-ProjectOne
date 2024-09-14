using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC_Project01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            // app.MapGet("/Home", () => "Hello World!");
            app.UseRouting();

            #region Routing
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello From Home");
            //    });

            //    endpoints.MapGet("/Products/{ID:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["ID"];

            //        if (idData is not null)
            //        {
            //            int data = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"Hello From Products  id => {data}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"Hello From Products");
            //        }
            //    });

            //    endpoints.MapGet("/Books/{ID}/{Author:alpha:minlength(6):maxlength(12)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Author"].ToString();

            //        await context.Response.WriteAsync($"Hello From Books  id=> {id} , At  Author => {name}");
            //    });

            //}); 
            #endregion

            // Controller 
            app.MapControllerRoute(
                name:"default",
                pattern:"/{Controller = Home }/{Action = Index}",
                defaults: new {Controller = "Home" , Action = "Index" }
                   
                );

            //app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Request  Page Is Not Found"); });
            app.Run();

    

        }
    }
}
