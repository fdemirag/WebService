using HotelProject.BusinessLayer.Abstracts;
using HotelProject.EntityLayer.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {

        private readonly IStaffService _staffService;
        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            _staffService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            return Ok(values);
        }
        //[HttpGet("Last4Staff")]
        //public IActionResult Last4Staff()
        //{
        //    var values = _staffService.TLast4Staff();
        //    return Ok(values);
        //}
    }
}