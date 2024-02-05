using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Entities;

namespace EmployeeMgmt
{
    public class Startup
    {
      
      public void ConfigureServices(IServiceCollection services)
      {
        services.AddControllersWithViews();
      }  

      public void Configure(IApplicationBuilder app,IHostEnvironment host)
      {
        if(host.IsDevelopment()){
        app.UseDeveloperExceptionPage();
        }
         
        app.UseHsts();
        app.UseRouting();
        app.UseStaticFiles();

        app.UseEndpoints(endpts=>{
          endpts.MapControllerRoute(name:"default",pattern:"{controller=Home}/{Action=Index}/{id?}");
        });
      } 
    }
}