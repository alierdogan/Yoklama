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
                return Result.ApiResult(result);
            }
            catch (Exception ex)
            {
                return Result.ApiResult(null, ex.Message);
            }
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
        public async Task<ActionResult> Add([FromBody] User user)
        {
            var result = await _service.AddAsync(user);
            return Result.ApiResult(result);
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<ActionResult> AddRange([FromBody] List<User> users)
        {
            var result = await _service.AddRangeAsync(users);
            return Result.ApiResult(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] User user)
        {
            var result = await _service.UpdateAsync(user);
            return Result.ApiResult(result);
        }
    }
}
