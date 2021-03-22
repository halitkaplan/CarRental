using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }


        [HttpGet("getallbyrental")]
        public IActionResult GetAllByBRental()
        {

            var result = _rentalService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyrentalid")]
        public IActionResult GetByBrandId(int rentalId)
        {

            var result = _rentalService.GetAllByRentalId(rentalId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyrentablecars")]
        public IActionResult GetByRentableCars(DateTime datetime)
        {

            var result = _rentalService.GetRentableCars(datetime);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("addrental")]
        public IActionResult Add(Rental rental)
        {

            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("deleterental")]
        public IActionResult Delete(Rental rental)
        {

            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("updaterental")]
        public IActionResult Update(Rental rental)
        {

            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
    }
}
