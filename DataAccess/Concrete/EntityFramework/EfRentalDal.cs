using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        

    }
}
