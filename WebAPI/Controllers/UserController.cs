using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IService<User> _service;
        public UserController(IService<User> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _service.GetListAsync();
                return result != null ? Ok(result) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
        public async Task<ActionResult> Add([FromBody] User user)
        {
            var result = await _service.AddAsync(user);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<User> users)
        {
            var result = await _service.AddRangeAsync(users);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] User user)
        {
            var result = await _service.UpdateAsync(user);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
