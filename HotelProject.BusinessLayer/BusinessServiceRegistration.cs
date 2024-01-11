using HotelProject.BusinessLayer.Abstracts;
using HotelProject.BusinessLayer.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ISubscribeService, SubscribeManager>();


            //  services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
