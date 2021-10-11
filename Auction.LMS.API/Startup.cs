using Auction.LMS.CORE.Common;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using Auction.LMS.INFRA;
using Auction.LMS.INFRA.Repoisitory;
using Auction.LMS.INFRA.Services;
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

namespace Auction.LMS.API
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

            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<ITestmonialRepoisitory, TestmonialRepoisitory>();
            services.AddScoped<IAuctionRepository, AuctionRepository>();
            services.AddScoped<ISalaryRepoisitory, SalaryRepoisitory>();
            services.AddScoped<IPaymentRepoisitory, PaymentRepoisitory>();
            services.AddScoped<IMessageRepoisitory, MessageRepoisitory>();
            services.AddScoped<ILoginRepoisitory, LoginRepoisitory>();
            services.AddScoped<IItemRepoisitory, ItemRepoisitory>();
            services.AddScoped<IImagesRepoisitory, ImagesRepoisitory>();
            services.AddScoped<IHomeRepoisitory, HomeRepoisitory>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<ITestmonialService, TestmonialService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ICreditCardService, CreditCardService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAuctionService, AuctionService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddControllers();

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
