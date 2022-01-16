using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BarberShopManager : IBerberShopService
    {
        IBarberDal _barberDal;

        public BarberShopManager(IBarberDal barberDal)
        {
            _barberDal = barberDal;
        }

        public IResult Add(BarberShop barberShop)
        {
            _barberDal.Add(barberShop);
            return new SuccessResult();
        }

        public IResult Delete(BarberShop barberShop)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BarberShop>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<BarberShop> GetById(int BarberShopId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BarberShop barberShop)
        {
            throw new NotImplementedException();
        }
    }
}
