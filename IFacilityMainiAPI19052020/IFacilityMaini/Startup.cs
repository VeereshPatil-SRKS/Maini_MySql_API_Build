using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFacilityMaini.DAL;
using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DBModels;
using IFacilityMaini.DBModels.ToolPulse;
using IFacilityMaini.Interface;
using IFacilityMaini.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace IFacilityMaini
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            #region local
            services.AddSingleton<IFileProvider>(
           new PhysicalFileProvider(
           Path.Combine("C:\\DMS", "")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "IFacility Maini", Version = "v1" });
            });

            //var connection = @"Server=TCP:172.16.8.5,1433;Database=unitworksccs;user id=sa;password=srks4$maini;";
            var connection = @"Server=EC2AMAZ-L5INV42\SQLEXPRESS;Database=unitworksccs;user id=sa;password=srks4$;";
            var connection1 = @"Server=EC2AMAZ-L5INV42\SQLEXPRESS;Database=i_facility_tsal;user id=sa;password=srks4$;";
            services.AddDbContext<unitworksccsContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<i_facility_tsalContext>(options => options.UseSqlServer(connection1));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    });
            });

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var commonEmailKey = (appSettings.CommonEmail);
            var documentEmail = (appSettings.DocumentEmail);
            var resetLinkURL = (appSettings.ResetLinkURL);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            #region configure DI for application services

            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IAccount, AccountDAL>();
            services.AddTransient<IOperatorDashboard, OperatorDashboardDAL>();
            services.AddTransient<IProductWiseDefectCode, ProductWiseDefectCodeDAL>();
            services.AddTransient<IListOfStoppage, ListOfStoppageDAL>();
            services.AddTransient<ITicket, TicketDAL>();
            services.AddTransient<IFGAndCellAllocation, FGAndCellAllocationDAL>();
            services.AddTransient<ILogin, LoginDAL>();
            services.AddTransient<IFgPartNo, FgPartNoDAL>();
            services.AddTransient<IReworkAndRejection, ReworkAndRejectionDAL>();
            services.AddTransient<IDryRun, DryRunDAL>();
            services.AddTransient<IOperator, OperatorDAL>();
            services.AddTransient<IToolLife, ToolLifeDAL>();

            #endregion
            #endregion
            #region server
            // services.AddSingleton<IFileProvider>(
            //new PhysicalFileProvider(
            //Path.Combine("D:\\DMS", "")));

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new Info { Title = "IFacility Maini", Version = "v7" });
            // });

            // var connection = @"Server=TCP:172.16.8.5,1433;Database=unitworksccs;user id=sa;password=srks4$maini;";
            // var connection1 = @"Server=TCP:SRKSDEV007\\SQLEXPRESS,1236;Database=i_facility_tsal;user id=sa;password=srks4$;";
            // services.AddDbContext<unitworksccsContext>(options => options.UseSqlServer(connection));
            // services.AddDbContext<i_facility_tsalContext>(options => options.UseSqlServer(connection1));

            // services.AddCors(options =>
            // {
            //     options.AddPolicy("AllowAllOrigins",
            //         builder =>
            //         {
            //             builder.AllowAnyOrigin();
            //             builder.AllowAnyHeader();
            //             builder.AllowAnyMethod();
            //         });
            // });

            // //configure strongly typed settings objects

            // var appSettingsSection = Configuration.GetSection("AppSettings");
            // services.Configure<AppSettings>(appSettingsSection);

            // //configure jwt authentication

            // var appSettings = appSettingsSection.Get<AppSettings>();
            // var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            // var commonEmailKey = (appSettings.CommonEmail);
            // var documentEmail = (appSettings.DocumentEmail);
            // var resetLinkURL = (appSettings.ResetLinkURL);

            // services.AddAuthentication(x =>
            // {
            //     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            // })
            // .AddJwtBearer(x =>
            // {
            //     x.RequireHttpsMetadata = false;
            //     x.SaveToken = true;
            //     x.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         ValidateIssuerSigningKey = true,
            //         IssuerSigningKey = new SymmetricSecurityKey(key),
            //         ValidateIssuer = false,
            //         ValidateAudience = false
            //     };
            // });

            // #region configure DI for application services

            // services.AddScoped<IUserService, UserService>();

            // services.AddTransient<IAccount, AccountDAL>();
            // services.AddTransient<IOperatorDashboard, OperatorDashboardDAL>();
            // services.AddTransient<IProductWiseDefectCode, ProductWiseDefectCodeDAL>();
            // services.AddTransient<IListOfStoppage, ListOfStoppageDAL>();
            // services.AddTransient<ITicket, TicketDAL>();
            // services.AddTransient<IFGAndCellAllocation, FGAndCellAllocationDAL>();
            // services.AddTransient<ILogin, LoginDAL>();
            // services.AddTransient<IFgPartNo, FgPartNoDAL>();
            // services.AddTransient<IReworkAndRejection, ReworkAndRejectionDAL>();
            // services.AddTransient<IDryRun, DryRunDAL>();
            // services.AddTransient<IOperator, OperatorDAL>();
            // services.AddTransient<IToolLife, ToolLifeDAL>();

            // #endregion
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            // Shows UseCors with CorsPolicyBuilder.
            app.UseCors("AllowAllOrigins");

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Maini IFacility API");
                c.DefaultModelsExpandDepth(-1); // hide model completely 
               // c.DefaultModelsExpandDepth(0); // collapse
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseAuthentication();

            //loggerFactory.AddLog4Net();
        }
    }
}
