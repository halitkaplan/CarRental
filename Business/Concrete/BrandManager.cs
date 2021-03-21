﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brand)
        {
            _brandDal = brand;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
      


        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {

             _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(),true);
        }

        public IDataResult<List<Brand>> GetAllByBrandId(int brandId)
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == brandId), true);
        }

     
    }
}
