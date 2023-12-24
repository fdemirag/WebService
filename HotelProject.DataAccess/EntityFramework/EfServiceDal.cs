using HotelProject.DataAccessLayer.Abstracts;
using HotelProject.DataAccessLayer.Concretes;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
