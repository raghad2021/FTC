using FTC.API.Controllers;
using FTC.Core.Dto;
using FTC.Service.Service.UserServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FTC.API.Controllers
{
    public class UserController : BaseControler
    {
        private IUserService _usersService;

        public UserController(IUserService userService)
        {
            _usersService = userService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _usersService.GetUsers();
            return Ok(users);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto dto)
        {
            await _usersService.Create(dto);
            return Ok("Done");
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateUserDto entity)
        {
            _usersService.Update(entity);
            return Ok("Done");
        }
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _usersService.Delete(id);
            return Ok(GetRespons());
        }
    
     }
}
