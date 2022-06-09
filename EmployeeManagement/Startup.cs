using EmployeeManagement.DataManager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Services.Contracts;

namespace EmployeeManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("The context is instantiated here ");
            services.AddControllers();
            String connectionString = "Server = localhost;port=3306;Database = employeedb; User ID = root; Password = root;Convert Zero Datetime=True";
            services.AddScoped<IVMstrategy_CommandId, VMstrategy_CommandId>();
             
            services.AddScoped<IVMInstanceSsmCommandIdMappingDataService, VMInstanceSsmCommandIdMappingDataService>();
            services.AddHttpContextAccessor();

            services.AddDbContextPool<SchoolContext>((serviceProvider, optionsBuilder) => { optionsBuilder.UseMySql(connectionString); },128);
    
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
