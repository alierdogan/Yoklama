using Business;
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
        public async Task<ActionResult> Add([FromBody] User user)
        {
            var result = await _service.AddAsync(user);
            return Ok(result.ReturnResult());
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<User> users)
        {
            var result = await _service.AddRangeAsync(users);
            return Ok(result.ReturnResult());
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] User user)
        {
            var result = await _service.UpdateAsync(user);
            return Ok(result.ReturnResult());
        }
    }
}
