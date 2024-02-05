namespace EmployeeMgmt
{
    public class Program
    {
        public static void Main(string[] args)
        {
           CreateHostBuilder(args).Run();
        }
        
        public static IHost CreateHostBuilder(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);
            builder.ConfigureWebHostDefaults(host=>host.UseStartup<Startup>());
            return builder.Build();
        }
    }
}