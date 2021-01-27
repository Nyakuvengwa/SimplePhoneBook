using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SimplePhoneBook.Api.Mappers;
using SimplePhoneBook.Common.API;
using SimplePhoneBook.Common.Service;
using SimplePhoneBook.Data.Data;
using SimplePhoneBook.Data.Repositories;

namespace SimplePhoneBook.Api
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SimplePhoneBook.Api", Version = "v1" });
            });
            
            services.AddDbContext<SimplePhoneBookDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IPhoneNumberTypeRepository, PhoneNumberTypeRepository>();

            services.AddTransient<IPhoneNumberTypeService, PhoneNumberTypeService>();

            services.AddAutoMapper(new ProfileRegistry().RegisteredProfiles);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SimplePhoneBook.Api v1"));
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
