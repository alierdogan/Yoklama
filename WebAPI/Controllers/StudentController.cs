using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly IService<Student> _service;
        public StudentController(IService<Student> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult> GetList()
        {
            var result = await _service.GetListAsync();
            return Result.ApiResult(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Result.ApiResult(result);
        }

        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return Result.ApiResult(result);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] Student Student)
        {
            var result = await _service.AddAsync(Student);
            return Result.ApiResult(result);
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<Student> Students)
        {
            var result = await _service.AddRangeAsync(Students);
            return Result.ApiResult(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Student Student)
        {
            var result = await _service.UpdateAsync(Student);
            return Result.ApiResult(result);
        }
    }
}
