using BeachCabinReservation.Data;
using BeachCabinReservation.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace BeachCabinReservation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                //avoid Camel Cased JSON
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); ;
            

            //setup EF
            var connStr = Configuration.GetSection("ConnectionStrings").GetValue<string>("AppConnectionString");
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(connStr));

            ConfigureWeb(services);
            ConfigureBusiness(services);
            ConfigureData(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var bldr = new ConfigurationBuilder()
                            .SetBasePath(env.ContentRootPath)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile("appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

            Configuration = bldr.Build();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            
        }

        public void ConfigureWeb(IServiceCollection services)
        {
        }

        private void ConfigureBusiness(IServiceCollection services)
        {
        }
        private void ConfigureData(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILogEntryRepository, LogEntryRepository>();
        }
    }
}
