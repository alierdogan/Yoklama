
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        [Route("All")]
        public async Task<ActionResult> Get()
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
        public async Task<ActionResult> Add([FromBody] School School)
        {
            var result = await _service.AddAsync(School);
            return Result.ApiResult(result);
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<School> Schools)
        {
            var result = await _service.AddRangeAsync(Schools);
            return Result.ApiResult(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] School School)
        {
            var result = await _service.UpdateAsync(School);
            return Result.ApiResult(result);
        }
    }
}
