using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //if ((rental.ReturnDate > rental.RentDate) || rental.ReturnDate == null)
            //{
            //    return new ErrorResult(Messages.CannotBeRented);
            //}
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.AddedRental);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletedRental);
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentalDal.GetAll(), true, "Kiralık Araçlar Listelendi.");
        }

        public IDataResult<List<Rental>> GetAllByRentalId(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.Id == rentalId));
        }

        public IDataResult<List<Rental>> GetRentableCars(DateTime dateTime)
        {


            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.ReturnDate <= dateTime), "Kiralanabilir Araçlar:");

        }

        
    }
}
