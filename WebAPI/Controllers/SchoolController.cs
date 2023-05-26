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
    public class SchoolController : ControllerBase
    {
        readonly IService<School> _service;
        public SchoolController(IService<School> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetList()
        {
            var result = await _service.GetListAsync();
            if (result == null || result.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }

            var lastResult = result.Select(item => new SchoolDto()
            {
                Order = result.ToList().IndexOf(item),
                Code = item.ID,
                Name = item.NAME
            });
            if (lastResult == null || lastResult.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            return new SuccessDataResponse<IEnumerable<SchoolDto>>(lastResult).ResponseOk();
        }

        [HttpGet]
        [Route("{accessCode:int?}")]
        public async Task<ActionResult> GetByAccessCode(int? accessCode = null)
        {
            List<School> result = null;

            if (accessCode.HasValue)
            {
                result = await _service.GetListWithIncludeAsync(null, f => f.Teachers.Where(f => f.Teacher.ACCESSCODE == accessCode));
            }
            else
            {
                result = await _service.GetListWithIncludeAsync(null, f => f.Teachers);
            }

            if (result == null || result.Count() == 0)
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
            else if (result.Any(f => f.Teachers.Count > 0))
            {
                var lastResult = result.OrderBy(f => f.ID).Where(f => f.Teachers.Count > 0).Select(item => new SchoolDto()
                {
                    Order = result.ToList().IndexOf(item),
                    Code = item.ID,
                    Name = item.NAME
                });
                return new SuccessDataResponse<IEnumerable<SchoolDto>>(lastResult).ResponseOk();
            }
            else
            {
                return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
            }
        }



        //[HttpGet]
        //[Route("{id:int}")]
        //public async Task<ActionResult> Get(int id)
        //{
        //    var result = await _service.GetByIdWithIncludeAsync(id);
        //    if (result == null)
        //    {
        //        return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
        //    }
        //    var lastResult = new SchoolDto()
        //    {
        //        Active = result.ACTIVE,
        //        Code = result.ID,
        //        Name = result.NAME
        //    };
        //    if (lastResult == null)
        //    {
        //        return new ErrorResponse("Kayıt bulunamadı").ResponseNotFound();
        //    }
        //    return new SuccessDataResponse<SchoolDto>(lastResult).ResponseOk();
        //}
    }
}
