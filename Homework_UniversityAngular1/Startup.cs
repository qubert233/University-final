using Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using University.AppContext;

namespace Homework_UniversityAngular1
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
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("myLocalConnStr"), b => b.MigrationsAssembly("University.WebApp")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddTransient<IAudiencesRepository, AudiencesRepository>();
            //services.AddTransient<IAudLectRepository, AudLectRepository>();
            //services.AddTransient<IDepartmentsRepository, DepartmentsRepository>();
            //services.AddTransient<IGroupsRepository, GroupsRepository>();
            //services.AddTransient<ILectionsRepository, LectionsRepository>();
            //services.AddTransient<IMarksRepository, MarksRepository>();
            //services.AddTransient<IPhonesRepository, PhonesRepository>();
            //services.AddTransient<ISpecialitiesRepository, SpecialitiesRepository>();
            //services.AddTransient<IStudentsRepository, StudentsRepository>();
            //services.AddTransient<ISubjectsRepository, SubjectsRepository>();
            //services.AddTransient<ITeachersRepository, TeachersRepository>();
            //services.AddTransient<ITeachSubjRepository, TeachSubjRepository>();

            

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials().Build();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseCors("EnableCORS");
            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.Options.StartupTimeout = new TimeSpan(0, 0, 300);
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
