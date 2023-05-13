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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_ => Configuration);
            //services.AddDbContext<WebAPIContext>(opt => opt.UseSqlServer(@"Data Source=127.0.0.1,1401; User ID=sa; Password=Aa123456; Initial Catalog=Yoklama; Trusted_Connection=True; TrustServerCertificate=True; Persist Security Info=True; Integrated Security=false;", opts => opts.MigrationsAssembly("DataAccess").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));
            services.AddDbContext<WebAPIContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("YoklamaDb"), opts => opts.MigrationsAssembly("DataAccess").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));
            services.AddControllers();

            services.AddTransient<IBaseDal<User>, EfBaseDal<User, WebAPIContext>>();
            services.AddTransient<IBaseDal<Person>, EfBaseDal<Person, WebAPIContext>>();
            services.AddTransient<IBaseDal<Teacher>, EfBaseDal<Teacher, WebAPIContext>>();
            services.AddTransient<IBaseDal<Student>, EfBaseDal<Student, WebAPIContext>>();
            services.AddTransient<IBaseDal<School>, EfBaseDal<School, WebAPIContext>>();

            services.AddTransient<IService<User>, Service<User>>();
            services.AddTransient<IService<Person>, Service<Person>>();
            services.AddTransient<IService<Teacher>, Service<Teacher>>();
            services.AddTransient<IService<Student>, Service<Student>>();
            services.AddTransient<IService<School>, Service<School>>();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(name: "default", pattern: "{controller=Versions}/{action=Get}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}
