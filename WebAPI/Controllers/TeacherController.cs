using Business;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Responses;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        readonly IService<Teacher> _service;
        public TeacherController(IService<Teacher> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetList()
        {
            var result = await _service.GetListWithIncludeAsync(null, f => f.Branch, f => f.Person);
            if (result == null || result.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            var lastResult = result.Select(item => new TeacherDto()
            {
                AccessCode = item.ACCESSCODE,
                Branch = item.Branch.NAME,
                Name = item.Person.NAME,
                Surname = item.Person.SURNAME
            });
            if (lastResult == null || lastResult.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            return new SuccessDataResponse<IEnumerable<TeacherDto>>(lastResult).ResponseOk();
        }

        [HttpGet]
        [Route("AccessCode/{accessCode:int}")]
        public async Task<ActionResult> GetByAccessCode(int accessCode)
        {
            var result = await _service.GetListWithIncludeAsync(f => f.ACCESSCODE == accessCode, f => f.Branch, f => f.Person);
            if (result == null || result.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            else
            {
                var lastResult = result.Select(item => new TeacherDto()
                {
                    AccessCode = item.ACCESSCODE,
                    Branch = item.Branch.NAME,
                    Name = item.Person.NAME,
                    Surname = item.Person.SURNAME
                });

                return new SuccessDataResponse<IEnumerable<TeacherDto>>(lastResult).ResponseOk();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _service.GetByIdWithIncludeAsync(id, f => f.Branch, f => f.Person);
            if (result == null)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            var lastResult = new TeacherDto()
            {
                AccessCode = result.ACCESSCODE,
                Branch = result.Branch.NAME,
                Name = result.Person.NAME,
                Surname = result.Person.SURNAME
            };
            if (lastResult == null)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            return new SuccessDataResponse<TeacherDto>(lastResult).ResponseOk();
        }

        //[HttpDelete]
        //[Route("Delete/{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var result = await _service.DeleteAsync(id);
        //    return Ok(result.ReturnResult());
        //}

        //[HttpPost]
        //[Route("Add")]
        //public async Task<ActionResult> Add([FromBody] Teacher Teacher)
        //{
        //    var result = await _service.AddAsync(Teacher);
        //    return Ok(result.ReturnResult());
        //}

        //[HttpPost]
        //[Route("AddRange")]
        //public async Task<ActionResult> AddRange([FromBody] List<Teacher> Teachers)
        //{
        //    var result = await _service.AddRangeAsync(Teachers);
        //    return Ok(result.ReturnResult());
        //}

        //[HttpPut]
        //[Route("Update")]
        //public async Task<ActionResult> Update([FromBody] Teacher Teacher)
        //{
        //    var result = await _service.UpdateAsync(Teacher);
        //    return Ok(result.ReturnResult());
        //}
    }
}
