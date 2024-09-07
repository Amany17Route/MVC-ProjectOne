namespace MVC_Project01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            Console.WriteLine("CreatDevBranch");

            Console.WriteLine("Create Session 2");

            app.Run();
        }
    }
}
