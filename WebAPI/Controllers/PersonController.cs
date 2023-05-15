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
        [Route("All")]
        public async Task<ActionResult> Get()
        {
            var result = await _service.GetListAsync();
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result != false ? Ok(result) : NotFound();
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add([FromBody] Person Person)
        {
            var result = await _service.AddAsync(Person);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<Person> Persons)
        {
            var result = await _service.AddRangeAsync(Persons);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Person Person)
        {
            var result = await _service.UpdateAsync(Person);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
