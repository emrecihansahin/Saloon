using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBerberShopService
    {
        IDataResult<List<BarberShop>> GetAll();
        IDataResult<BarberShop> GetById(int BarberShopId);
        IResult Add(BarberShop barberShop);
        IResult Delete(BarberShop barberShop);
        IResult Update(BarberShop barberShop);

    }
}
