using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //private string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_ => Configuration);
            //services.AddDbContext<WebAPIContext>(opt => opt.UseSqlServer(@"Data Source=127.0.0.1,1401; User ID=sa; Password=Aa123456; Initial Catalog=Yoklama; Trusted_Connection=True; TrustServerCertificate=True; Persist Security Info=True; Integrated Security=false;", opts => opts.MigrationsAssembly("DataAccess").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));
            services.AddDbContext<WebAPIContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("YoklamaDb"), opts => opts.MigrationsAssembly("DataAccess").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));

            //services.AddCors();
            //services.AddMvc();

            services.AddControllers();
            services.AddTransient<IUserDal, EfUserDal>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPersonDal, EfPersonDal>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<ITeacherDal, EfTeacherDal>();
            services.AddTransient<ITeacherService, TeacherService>();
            //services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            //{
            //    builder.AllowAnyOrigin()
            //           .AllowAnyMethod()
            //           .AllowAnyHeader();
            //}));
            //services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            //app.UseHttpsRedirection();


            app.UseRouting();

            //app.UseCors(opt=>opt.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            //app.UseCors();
            app.UseOptions();
            //app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Test}/{action=Get}/{id?}");
                //endpoints.MapControllers();
            });
        }
    }
}
