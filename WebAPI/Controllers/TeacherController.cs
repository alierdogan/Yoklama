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
    public class TeacherController : ControllerBase
    {
        readonly IService<Teacher> _service;
        public TeacherController(IService<Teacher> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult> GetList()
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
        public async Task<ActionResult> Add([FromBody] Teacher Teacher)
        {
            var result = await _service.AddAsync(Teacher);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<Teacher> Teachers)
        {
            var result = await _service.AddRangeAsync(Teachers);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Teacher Teacher)
        {
            var result = await _service.UpdateAsync(Teacher);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
