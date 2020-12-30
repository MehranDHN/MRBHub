using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Piranha;
using Piranha.AttributeBuilder;
using Piranha.AspNetCore.Identity.SQLite;
using Piranha.Data.EF.SQLite;
using Piranha.Manager.Editor;
using Piranha.Data.EF.SQLServer;
using Piranha.AspNetCore.Identity.SQLServer;
using System;
using Microsoft.OpenApi.Models;
using MRBHub.RealTime;
using MRBHub.Adapter;

namespace MRBHub
{
    public class Startup
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="configuration">The current configuration</param>
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Manuscripts & Rare Books API", Version = "v1" });
                options.CustomSchemaIds(x => x.FullName);
            });
            // Service setup
            services.AddPiranha(options =>
            {
                options.AddRazorRuntimeCompilation = true;

                options.UseFileStorage(naming: Piranha.Local.FileStorageNaming.UniqueFolderNames);
                options.UseImageSharp();
                options.UseManager();
                options.UseTinyMCE();
                options.UseMemoryCache();
                options.UseEF<SQLServerDb>(db =>
                                db.UseSqlServer(_config.GetConnectionString("mrb")));
                options.UseIdentity<IdentitySQLServerDb>(
                    dbOptions: db => db.UseSqlServer(_config.GetConnectionString("mrb")),
                    identityOptions: io =>
                    {
                        // Password settings
                        io.Password.RequireDigit = false;
                        io.Password.RequiredLength = 6;
                        io.Password.RequireNonAlphanumeric = false;
                        io.Password.RequireUppercase = false;
                        io.Password.RequireLowercase = false;
                        io.Password.RequiredUniqueChars = 1;

                        // Lockout settings
                        io.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                        io.Lockout.MaxFailedAccessAttempts = 10;
                        io.Lockout.AllowedForNewUsers = true;

                        // User settings
                        io.User.RequireUniqueEmail = false;
                    },
                    cookieOptions: co =>
                    {
                        co.Cookie.HttpOnly = true;
                        co.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                        co.LoginPath = "/manager/login";
                        co.AccessDeniedPath = "/manager/login";
                        co.SlidingExpiration = true;
                    });

                /***
                 * Here you can configure the different permissions
                 * that you want to use for securing content in the
                 * application.
                options.UseSecurity(o =>
                {
                    o.UsePermission("WebUser", "Web User");
                });
                 */
            });

            services.AddTransient<IAdapterEngine, AdapterEngine>();

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApi api)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("http://37.156.28.208/cmsdemo/swagger/v1/swagger.json", "Manuscripts & Rare Books API V1");
            });
            // Initialize Piranha
            App.Init(api);

            App.MediaTypes.Images.Add(".svg", "image/svg+xml");
            App.MediaTypes.Images.Add(".tif", "image/tiff");

            // Build content types
            new ContentTypeBuilder(api)
                .AddAssembly(typeof(Startup).Assembly)
                .Build()
                .DeleteOrphans();

            // Configure Tiny MCE
            EditorConfig.FromFile("editorconfig.json");

            // Middleware setup
            app.UsePiranha(options => {
                options.UseManager();
                options.UseTinyMCE();
                options.UseIdentity();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<MRBSignalRHub>("/mrbsignalrhub");
            });
        }
    }
}
