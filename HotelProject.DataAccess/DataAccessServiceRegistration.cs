using HotelProject.DataAccessLayer.Abstracts;
using HotelProject.DataAccessLayer.Concretes;
using HotelProject.DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer
{
    public static  class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            // services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));

            services.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString("HotelProject")));


            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();


            return services;
        }
    }
}
