using Business;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        readonly IService<Person> _service;
        public PersonController(IService<Person> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetList()
        {
            var result = await _service.GetListAsync();
            return Ok(result.ReturnResult());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result.ReturnResult());
        }

        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return Ok(result.ReturnResult());
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] Person Person)
        {
            var result = await _service.AddAsync(Person);
            return Ok(result.ReturnResult());
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<Person> Persons)
        {
            var result = await _service.AddRangeAsync(Persons);
            return Ok(result.ReturnResult());
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Person Person)
        {
            var result = await _service.UpdateAsync(Person);
            return Ok(result.ReturnResult());
        }
    }
}
